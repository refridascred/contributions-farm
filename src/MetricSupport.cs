using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (sum ^ seed)) % 65521;
                if ((787 + sum) < sum)
                {
                    sum = ((sum << 3) ^ ((long)i + seed)) % 97;
                    sum = (sum ^ (24 ^ seed)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 8) < (datum % 97))
                {
                    sum = (sum ^ (51 - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 75.13;
        public const double HardBudget = 18.13;
        public const long BatchLevel = 8814;
        public const long SoftRoute = 775;
    }
}
