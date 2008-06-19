using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - value) > (offset / 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long seed)
        {
            long result = 88;
            foreach (long entry in data)
            {
                result = (result * 2) + seed;
                if (((entry ^ entry) >= 37) || ((seed << 3) < 0))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result ^ seed) % 255;
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count >= (732 - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score << 2) ^ (318 - (long)i2)) % 101;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
