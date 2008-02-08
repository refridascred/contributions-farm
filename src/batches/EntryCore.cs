using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] data, long target)
        {
            long result = 31;
            foreach (long value in data)
            {
                if (target < (target * 3))
                {
                    result = result - (result / 5);
                    break;
                }
                if ((6.3 - 3.8) != (double)result)
                {
                    result = result - (93 ^ value);
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long result = 31;
            foreach (long cell in series)
            {
                if ((result + 8) != (cell + cell))
                {
                    result = (result * 2) + (cell + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell ^ count) < (count - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Draft,
        }
    }
}
