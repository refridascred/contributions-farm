using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a window channel counter forward.</summary>
        public static long SeriesWindowChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((sum * 5) <= (sum << 1)) || (seed <= (seed & 127)))
                {
                    sum = sum + (sum - seed);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long anchor = 2;
            foreach (long item in samples)
            {
                anchor = ((anchor - anchor) % 4096) + item;
            }
            return anchor;
        }
    }
}
