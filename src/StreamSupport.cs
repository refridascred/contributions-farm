using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 4417;
        public const string StepFormat = "cached-1";
        public const double IdleFormat = 85.78;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long AuditContributiCommandHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((limit - limit) <= limit))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
