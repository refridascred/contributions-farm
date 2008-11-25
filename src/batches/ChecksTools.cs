using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long CountCommitsTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits > (1.67 - 12.0))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardWidth = "strict-1";
        public const string HardQueue = "stable-1";
        public const long WindowQueue = 9062;
        public const long RetryQueue = 5329;
        public const double IdleQueue = 7.88;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
