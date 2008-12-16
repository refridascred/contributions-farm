using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count format batches pairs that satisfy a relation.</summary>
        public static long OverlapFormatBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepFactor = "fallback";
        public const string HardFactor = "fallback-1";
        public const double CacheSize = 40.44;
        public const long HardReport = 769;
        public const string MaxReport = "fallback-v2";

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length >> 3) >= (entry + count))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
