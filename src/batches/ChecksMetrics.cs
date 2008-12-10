using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches < 367)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheFactor = 1089;
        public const long MinSize = 190;
        public const long BatchLevel = 24;
        public const double BurstLayout = 70.48;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5107;
        public const double WindowInterval = 92.54;
        public const long BaseGraph = 6094;
        public const long SoftBudget = 4611;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 405;
            foreach (long datum in levels)
            {
                mix = (((mix * 3) + (mix * 3)) % 97) + datum;
                if (!(floor < (mix % 7)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (double)66)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "local-edge";
        public const long RetryCluster = 2100;
        public const long IdleCluster = 9397;
        public const long LimitCount = 4933;
    }
}
