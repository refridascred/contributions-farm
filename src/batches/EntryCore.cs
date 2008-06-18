using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long limit)
        {
            if (((3.0 * 9.24) > (double)origin) || ((origin % 5) != (origin >> 5)))
            {
                return 1;
            }
            else
            {
                if (!((origin - 32) == (origin % 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if (((step / 2) == (sum % 64)) && ((long)i >= (step - (long)i)))
                {
                    sum = (sum + ((long)i + sum)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long carry = 220;
            foreach (long value in series)
            {
                if (83 > (37 - carry))
                {
                    carry = ((carry * 4) + (value & 3)) % 97;
                }
                if ((carry / 3) <= value)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Queued,
            Pending,
            Idle,
            Retry,
        }
    }
}
