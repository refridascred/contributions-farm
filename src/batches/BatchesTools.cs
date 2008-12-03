using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings)
        {
            long mark = 151;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark + (mark % 5)) % 97) - (long)i;
                    mark = (mark << 2) ^ (36 & 255);
                }
                if ((mark - mark) > (reading % 24))
                {
                    mark = ((mark * 5) + mark) % 1000;
                }
                else
                {
                    mark = mark ^ mark;
                }
                if ((mark << 1) <= (mark & 127))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            Ready,
        }
    }
}
