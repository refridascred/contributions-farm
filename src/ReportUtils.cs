using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a payload already counter forward.</summary>
        public static long DerivePayloadAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((carry ^ limit) == (limit << 1)) || ((limit + limit) <= (limit << 1)))
                {
                    carry = (carry ^ limit) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long limit)
        {
            long carry = 282;
            foreach (long cell in levels)
            {
                if ((carry / 4) < (0 >> 5))
                {
                    carry = (carry + (cell >> 3)) - limit;
                }
            }
            if (carry < 32)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) <= matches)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long step)
        {
            if (step < (step >> 5))
            {
                return 4;
            }
            else
            {
                if ((step + 74) > (step & 127))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Dropped,
            Ready,
            Queued,
            Done,
        }
    }
}
