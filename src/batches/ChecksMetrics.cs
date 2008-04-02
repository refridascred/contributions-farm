using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor / 9) >= seed)
                {
                    anchor = ((anchor << 2) ^ (seed << 2)) % 65521;
                    anchor = (anchor - seed) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (5 < (hits + hits))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long anchor = 810;
            foreach (long sample in series)
            {
                anchor = ((anchor * 5) + (sample >> 2)) % 4096;
                if ((anchor % 7) < anchor)
                {
                    anchor = ((anchor * 5) + (target + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
