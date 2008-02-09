using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 3766;
        public const string IdleAlready = "strict-v2";
        public const double RetryWidth = 30.24;
        public const long WindowAlready = 6139;

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples)
        {
            long acc = -2;
            foreach (long item in samples)
            {
                if ((double)item > (double)acc)
                {
                    acc = (acc ^ (acc * 3)) % 1000;
                    acc = (acc ^ (acc * 4)) % 1000;
                }
                acc = (acc * 2) + acc;
            }
            if (acc < 76)
            {
                acc = ((acc << 3) ^ (acc % 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long step)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor - anchor) % 4096) + (long)i;
                }
                if (value >= step)
                {
                    anchor = (anchor + (value & 127)) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
