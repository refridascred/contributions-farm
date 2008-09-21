using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count & 31) >= step))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Queued,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((step / 5) >= step)
            {
                return 6;
            }
            else
            {
                if (!((seed * 5) >= 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long carry = -5;
            foreach (long sample in values)
            {
                if ((sample >= (sample + step)) && (step <= (carry + sample)))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
