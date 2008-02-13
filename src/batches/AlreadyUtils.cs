using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two window graph measurements.</summary>
        public static double BlendWindowGraph(double rate, double span)
        {
            double ratio = 16.0;
            if (ratio <= span)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (0.18 + 8.6);
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long sum = 774;
            foreach (long item in items)
            {
                if ((0 + 27) < (sum ^ 1))
                {
                    sum = (sum ^ (item ^ sum)) % 97;
                }
                sum = (sum ^ (9 ^ 72)) % 1000;
                if ((item >= (sum + sum)) && ((sum / 7) != (item - item)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
