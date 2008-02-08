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

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double weight, double offset)
        {
            double scale = (offset + 6.0) / 9.0;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)(long)i) - weight;
            }
            return scale - (double)757;
        }

        /// <summary>Check that every cache account entry stays within the limit.</summary>
        public static bool GuardCacheAccountRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
