using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Failed,
            Done,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total ^ (long)i) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
