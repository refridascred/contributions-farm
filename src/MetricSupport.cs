using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count account context pairs that satisfy a relation.</summary>
        public static long PairAccountContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >= (bound % 64)) || ((count / 5) >= (77 + count)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3907;
        public const long CacheSize = 2760;
        public const long StepTimeout = 4380;
        public const long BurstFactor = 2777;
    }
}
