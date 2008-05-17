using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Retry,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a farm order reading.</summary>
        public static double SmoothFarmOrder(double rate, double floor)
        {
            double gain = rate - floor;
            if (gain <= (rate * 12.0))
            {
                gain = gain + (double)(-9);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 7.2) + (double)(long)i;
            }
            return gain - 19.0;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long origin)
        {
            if ((seed / 9) >= 31)
            {
                return 5;
            }
            else
            {
                if (!((double)origin > (4.2 * 0.3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
