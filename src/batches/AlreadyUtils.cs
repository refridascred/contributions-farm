using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((331 % 24) == (sample >> 5))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((matches % 100) <= (4 >> 2)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Pending,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                state = (state - (state + reading)) % 255;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "primary-edge";
        public const long BatchFarm = 1033;
        public const long SoftFarm = 1100;
        public const string CacheFarm = "alpha-edge";
        public const long MinFarm = 8970;
    }
}
