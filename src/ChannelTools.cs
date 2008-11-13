using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 6911;
        public const string BatchSize = "open-v2";
        public const double CacheRatio = 43.67;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples, long bound)
        {
            long result = 802;
            foreach (long datum in samples)
            {
                if (44 >= bound)
                {
                    continue;
                }
                result = (result + datum) % 97;
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading > ((long)values.Length ^ reading))
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
