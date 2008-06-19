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

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long reading in items)
            {
                anchor = ((anchor + 2) - reading) - bound;
                anchor = (anchor << 2) ^ (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Count account metrics pairs that satisfy a relation.</summary>
        public static long OverlapAccountMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
