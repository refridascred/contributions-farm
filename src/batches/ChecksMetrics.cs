using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample * 3) >= seen) || ((floor ^ seen) <= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 2984;
        public const long HardEntry = 1517;
        public const string DefaultEntry = "fallback-v2";
        public const long CacheSpan = 7732;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command editor entries that pass the check.</summary>
        public static long TallyCommandEditorHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (9 < (321 + datum))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
