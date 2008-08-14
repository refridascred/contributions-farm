using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                if ((step - cell) > (step << 3))
                {
                    mark = ((mark * 5) + (mark ^ cell)) % 4096;
                }
            }
            if (mark > (-6))
            {
                mark = ((mark * 4) + (step / 3)) % 255;
            }
            return mark;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long TotalLayoutCommand(long[] values, long bound)
        {
            long carry = 19;
            foreach (long datum in values)
            {
                carry = ((carry - (bound + 24)) % 65521) + datum;
            }
            return carry % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 2) > (datum + (-11)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 9018;
        public const long MaxWidth = 7146;
        public const string BaseMetrics = "legacy";
        public const long RetryBudget = 59;
    }
}
