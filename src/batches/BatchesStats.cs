using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data)
        {
            long carry = 9;
            foreach (long cell in data)
            {
                if ((cell >= (carry & 63)) && ((carry << 1) > cell))
                {
                    carry = (carry * 5) + (cell & 3);
                }
                else
                {
                    carry = ((carry << 3) ^ (25 + cell)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Pending,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - ((long)i ^ (-522))) % 65521;
                mark = (mark << 3) ^ (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((seed + next) >= next)
            {
                return 1;
            }
            else
            {
                if ((4 - seed2) >= (seed2 << 3))
                {
                    return 0;
                }
                else
                {
                    if (((double)next >= (9.0 / 4.0)) && ((next << 2) > (next / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
