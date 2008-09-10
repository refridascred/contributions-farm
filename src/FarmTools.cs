using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + 37) == (entry / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long target)
        {
            if (((origin >> 5) >= (origin << 3)) || ((target % 2) <= (target ^ target)))
            {
                return 2;
            }
            else
            {
                if ((51 << 1) >= (origin << 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
