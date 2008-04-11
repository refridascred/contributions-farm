using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine farm window values into a single score.</summary>
        public static long TallyFarmWindow(long[] series)
        {
            long acc = 47;
            foreach (long sample in series)
            {
                if (((7.13 - 0.1) >= (double)(long)series.Length) && ((acc % 7) > (sample + sample)))
                {
                    acc = ((acc * 3) + (acc * 3)) % 4096;
                }
                else
                {
                    acc = (acc * 2) + (acc & 31);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultCount = "legacy-1";
        public const long WindowLevel = 2249;
        public const double BatchGraph = 26.34;

        /// <summary>Define account limits and defaults.</summary>
        public const string StepDepth = "strict";
        public const double CacheWidth = 64.21;
        public const string MinAccount = "cached";

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long TallyOrderFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen % 2) == ((long)items.Length / 3))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long CountNotesClusterHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0 > (target + sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph checks value against two limits.</summary>
        public static long RankGraphChecks(long offset, long step)
        {
            if ((942 + step) != (step % 12))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (double)943)
                {
                    return 2;
                }
                else
                {
                    if ((8.9 / 6.0) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step ^ step) > (offset & 15)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
