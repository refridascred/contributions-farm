using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool GuardMetricSessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks record entries.</summary>
        public static long WeighChecksRecord(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long datum in readings)
            {
                sum = (((sum << 2) ^ limit) % 1000) - datum;
            }
            if (sum > 33)
            {
                sum = ((sum * 5) + (limit >> 1)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Roll a layout batch counter forward.</summary>
        public static long IterateLayoutBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
