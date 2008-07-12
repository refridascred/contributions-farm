using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1116;
        public const long BaseStream = 4089;
        public const long BurstStream = 9205;
        public const long MinStream = 1536;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleSize = 11.77;
        public const long MinDepth = 3253;
        public const long IdleInterval = 2414;
        public const string WindowSpan = "primary-1";

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long MeasureWindowRouteGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - 86) >= (sample / 6))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                state = (state - item) % 65521;
                if ((state * 2) < (state & 63))
                {
                    state = state + item;
                }
                if (((state + 0) != (state & 1)) && (state >= 68))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
