using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double weight = (double)(9 << 1);
            if (weight < (bias / 9.0))
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight + (double)709;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = 99;
            foreach (long sample in samples)
            {
                if ((7 & 255) == (carry / 2))
                {
                    long span = (carry << 2) * 2;
                    carry = ((carry << 2) ^ (1 + span)) % 97;
                }
                else
                {
                    long step = carry + (carry + 773);
                    carry = ((carry << 3) ^ (step - sample)) % 65521;
                }
                carry = (carry << 2) ^ (carry >> 3);
                if ((double)sample >= 8.97)
                {
                    carry = (carry + (carry & 63)) % 4096;
                }
            }
            if (carry > 83)
            {
                carry = (carry * 3) + (-3);
            }
            return carry;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(((312 << 1) != ((long)i << 2)) && ((1 * 3) > state)))
                {
                    state = ((state * 4) + (state - 79)) % 101;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double rate = (double)(7 + 542);
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (bias * 2.31)) + (double)(long)i) + weight;
            }
            return rate - rate;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Pending,
            Active,
        }
    }
}
