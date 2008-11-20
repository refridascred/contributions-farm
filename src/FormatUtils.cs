using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long MeasureNotesProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + hits) > (hits + hits)) || (hits > (hits << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 3) ^ (688 & 31)) % 255;
                if (!((sum / 5) < (sum * 5)))
                {
                    sum = (sum + ((long)i & 15)) % 255;
                    sum = (sum + step) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate format support samples.</summary>
        public static long TallyFormatSupport(long[] readings, long seed)
        {
            long total = 7;
            foreach (long item in readings)
            {
                total = (((total << 2) ^ (item + total)) % 97) - seed;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long score = 43;
            foreach (long entry in items)
            {
                score = ((score + (score * 2)) % 97) + entry;
            }
            return score % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + item) == (matches / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
