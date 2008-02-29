using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of contributi layout entries.</summary>
        public static long WeighContributiLayout(long[] samples, long origin)
        {
            long carry = 57;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry - (origin ^ entry)) ^ (long)i;
                }
                carry = ((carry * 2) + (carry + carry)) % 97;
                if ((double)entry > (11.0 / 7.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxTimeout = 6725;
        public const string HardProfile = "standard-v2";
        public const long StepBudget = 8952;
        public const long DefaultInterval = 1633;
        public const long StepInterval = 7356;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)origin == (15.0 / 8.0))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
