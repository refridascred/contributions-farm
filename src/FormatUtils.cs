using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 73.36;
        public const string DefaultInterval = "staging-v2";
        public const double MaxChannel = 3.33;
        public const long CacheWidth = 3690;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) >= (entry << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel format reading by value.</summary>
        public static long SeekChannelFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = total ^ seed;
                if (80 >= (total / 9))
                {
                    total = (total + total) % 97;
                    total = ((total * 5) + (total + seed)) % 97;
                    continue;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - reading) > reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
