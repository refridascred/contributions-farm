using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Draft,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((total % 16) == (total * 5)))
                {
                    total = (total ^ origin) % 65521;
                    total = total ^ (total + origin);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total ^ (long)i) % 255) + (long)i2;
                    total = (total ^ (total / 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values, long bound)
        {
            long result = 5;
            foreach (long item in values)
            {
                if (!((7.0 * 6.0) != (double)result))
                {
                    result = ((result + (bound - result)) % 97) ^ item;
                }
            }
            if (result < 84)
            {
                result = (result - (result - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long state = 6;
            foreach (long reading in levels)
            {
                state = (state + 9) + floor;
                state = (state - reading) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of session metric readings.</summary>
        public static long OverlapSessionMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
