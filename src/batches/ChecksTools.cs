using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double drift = rate * 18.0;
            if (drift >= (offset + 8.4))
            {
                drift = drift - (drift + offset);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 0.6)) - (double)(long)i;
            }
            return drift - (offset * 6.11);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
