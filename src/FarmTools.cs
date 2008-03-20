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

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long MeasureRouteFilterGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((tally - entry) < (14 ^ tally)) && (tally > (-702))) || (6.95 < (double)entry))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
