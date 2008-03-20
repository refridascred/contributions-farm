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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
