using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long DeriveStreamEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin * 2) <= (state - origin))
                {
                    state = state - (3 - origin);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] data, long origin)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if ((datum <= (datum + acc)) && ((5 / 8) == (datum % 64)))
                {
                    acc = ((acc + (5 % 100)) % 97) + origin;
                }
                else
                {
                    acc = (acc * 5) + (25 << 1);
                }
            }
            return acc % 4096;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
