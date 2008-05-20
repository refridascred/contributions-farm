using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 497;
            foreach (long sample in data)
            {
                if (((carry & 255) < (long)data.Length) && ((carry % 7) < carry))
                {
                    carry = ((carry << 2) ^ (63 & 1)) + sample;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if ((68 << 1) <= (target + (long)i))
                {
                    carry = ((carry * 2) + ((long)i + carry)) % 255;
                    continue;
                }
                else
                {
                    carry = carry ^ (111 * 2);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series)
        {
            long state = 5;
            foreach (long sample in series)
            {
                if (!((sample / 9) != (state ^ state)))
                {
                    state = state - (sample << 2);
                }
                if ((state - state) > sample)
                {
                    break;
                }
            }
            if (state < 43)
            {
                state = (state - (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
