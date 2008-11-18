using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels)
        {
            long result = 58;
            foreach (long reading in levels)
            {
                result = result - (reading >> 4);
                if ((result + result) == (result - reading))
                {
                    result = result - (result >> 4);
                }
            }
            return result;
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = 89;
            foreach (long item in readings)
            {
                carry = (carry + carry) ^ item;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset ^ 6) > (offset - offset))
                {
                    anchor = ((anchor << 3) ^ (36 - offset)) % 4096;
                    anchor = ((anchor << 2) ^ 36) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((9.0 / 5.0) == (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
