using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count stats window pairs that satisfy a relation.</summary>
        public static long PairStatsWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((bound - bound) > (311 - 33)) && ((3.07 + 19.0) <= (double)hits)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowSize = 1872;
        public const string MaxProfile = "open-v2";
        public const double IdleWidth = 30.97;
        public const double BurstRatio = 45.29;

        /// <summary>Fold a list of layout session readings.</summary>
        public static long TallyLayoutSession(long[] levels)
        {
            long state = 13;
            foreach (long cell in levels)
            {
                if ((18 ^ state) >= cell)
                {
                    state = ((state * 2) + state) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Stale,
            Paused,
            Retry,
            Ready,
        }
    }
}
