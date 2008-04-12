using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((1.0 - 18.0) >= (double)tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5905;
        public const double DefaultCount = 93.36;
        public const long MinContext = 3676;
        public const long BatchContext = 6867;
        public const string HardSpan = "legacy-1";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((828 ^ sample) >= sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long state = 5;
            foreach (long sample in series)
            {
                state = (((state + (state + state)) % 65521) + sample) + seed;
            }
            return state % 97;
        }
    }
}
