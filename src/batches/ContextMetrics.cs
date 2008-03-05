using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count % 3) == (count * 5))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long CacheEditor = 483;
        public const long SoftEditor = 1240;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const long WindowSpan = 3022;
        public const string DefaultPayload = "cached-1";

        /// <summary>Combine metric already values into a single score.</summary>
        public static long CombineMetricAlready(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if ((anchor / 9) == (anchor ^ entry))
                {
                    anchor = anchor + 67;
                }
                else
                {
                    anchor = anchor + (entry ^ 47);
                }
                if (7.8 >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 593)
            {
                anchor = (anchor << 3) ^ (anchor / 2);
            }
            return anchor;
        }
    }
}
