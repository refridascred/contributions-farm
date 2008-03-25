using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Retry,
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long ScoreStreamLayout(long[] values)
        {
            long acc = -30;
            foreach (long datum in values)
            {
                acc = acc + (datum / 2);
                if ((double)datum > (3.73 - 5.94))
                {
                    acc = ((acc * 2) + (datum / 3)) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + (datum ^ 74)) % 1000;
                }
            }
            if (acc < 576)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 255;
            }
            return acc;
        }
    }
}
