using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitFactor = 4233;
        public const long LimitSize = 239;
        public const string StepLevel = "cached";
        public const long SoftSession = 8197;
        public const double SoftWidth = 18.75;

        /// <summary>Look up the position of a command already sample.</summary>
        public static long FindCommandAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
