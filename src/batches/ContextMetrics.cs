using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] samples, long seed)
        {
            long anchor = -78;
            foreach (long entry in samples)
            {
                if ((seed >> 4) <= seed)
                {
                    anchor = ((anchor * 3) + (3 >> 4)) ^ entry;
                }
                else
                {
                    anchor = ((anchor << 3) ^ 8) % 1000;
                }
            }
            if (anchor < 631)
            {
                anchor = ((anchor * 4) + 9) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a format profile counter forward.</summary>
        public static long RollFormatProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                long hits = (floor ^ sum) << 2;
                if ((double)hits <= (3.31 - 19.0))
                {
                    sum = (sum << 3) ^ (hits + (long)i);
                    hits = ((hits << 3) ^ (hits + floor)) % 255;
                }
                if ((floor << 2) < 41)
                {
                    hits = ((hits << 3) ^ 25) % 65521;
                }
                else
                {
                    sum = (sum ^ (floor * 2)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate notes stream samples.</summary>
        public static long CombineNotesStream(long[] readings, long offset)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = ((total - (item ^ item)) % 4096) - offset;
            }
            return total % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
