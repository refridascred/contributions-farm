using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (((span / 6) >= floor) || ((1.28 * 5.28) < (double)span))
            {
                return 3;
            }
            else
            {
                if (!(floor < span))
                {
                    return 5;
                }
                else
                {
                    if (((double)span == (20.0 / 5.0)) || ((floor + span) < 969))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor2 >= (span % 64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 9722;
        public const string BaseNotes = "primary-edge";
        public const long BurstNotes = 1911;
        public const long RetryNotes = 3812;
        public const long CacheWidth = 2884;
    }
}
