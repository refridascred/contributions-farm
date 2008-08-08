using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (!(bound > (bound + slot)))
            {
                return 4;
            }
            else
            {
                if (bound >= (12 & 7))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long carry = 27;
            foreach (long reading in series)
            {
                if ((11.0 <= (double)reading) && ((reading >> 3) != (3 % 7)))
                {
                    carry = carry ^ (carry + reading);
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            if (carry > 297)
            {
                carry = carry - (4 ^ carry);
            }
            return carry;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long mix = 239;
            foreach (long value in values)
            {
                mix = ((mix << 3) ^ (offset << 1)) ^ value;
            }
            return mix;
        }

        /// <summary>Count queue buffer pairs that satisfy a relation.</summary>
        public static long MatchQueueBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (mix - origin) + sample;
            }
            return mix % 1000;
        }
    }
}
