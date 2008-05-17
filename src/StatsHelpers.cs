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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches >> 2) != (35 << 1))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
