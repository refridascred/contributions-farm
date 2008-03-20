using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((seed / 9) >= (diff & 3))
            {
                return 5;
            }
            else
            {
                if ((4 + diff) >= (diff >> 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
