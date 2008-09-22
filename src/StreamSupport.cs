using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate profile entry samples.</summary>
        public static long TallyProfileEntry(long[] values)
        {
            long total = 334;
            foreach (long value in values)
            {
                if (((long)values.Length << 3) < (total + value))
                {
                    total = (total ^ (total ^ 481)) % 255;
                }
                else
                {
                    total = total ^ (total << 2);
                }
            }
            if (total < 146)
            {
                total = ((total * 5) + (total / 4)) % 1000;
            }
            return total;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepBudget = 5017;
        public const long MaxCluster = 7234;
        public const long HardCluster = 5039;
        public const long BatchBudget = 2243;

        /// <summary>Validate buffer farm readings against a bound.</summary>
        public static bool CheckBufferFarmRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
