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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 3) > (floor * 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
