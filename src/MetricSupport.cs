using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long step, long step2)
        {
            long next = step ^ step2;
            if ((step2 << 1) < (step2 - (-685)))
            {
                return 1;
            }
            else
            {
                if ((next % 100) == (next % 97))
                {
                    return 0;
                }
                else
                {
                    if ((next << 2) == (next - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseFactor = "strict-v2";
        public const long MinCluster = 5474;
        public const long LimitCluster = 2133;
        public const long BaseScore = 6539;
        public const long LimitDepth = 214;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                mark = ((mark + (975 & 7)) % 97) ^ reading;
            }
            return mark % 4096;
        }
    }
}
