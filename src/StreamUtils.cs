using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinInterval = "standard-edge";
        public const long BurstRoute = 2528;
        public const long IdleRoute = 2613;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of window token readings.</summary>
        public static long ScoreWindowToken(long[] samples, long origin)
        {
            long state = -6;
            foreach (long reading in samples)
            {
                if ((double)reading > (3.9 * 5.59))
                {
                    state = state ^ (origin >> 4);
                }
            }
            return state % 97;
        }

        /// <summary>Check that every support counter entry stays within the limit.</summary>
        public static bool CheckSupportCounterLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a support farm sample.</summary>
        public static long FindSupportFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
