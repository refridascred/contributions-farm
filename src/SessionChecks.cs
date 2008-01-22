using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next stats token value.</summary>
        public static double ProjectStatsToken(double rate, double span)
        {
            double gain = 8.4;
            if (gain > (rate / 5.0))
            {
                gain = (gain + rate) - span;
            }
            else
            {
                gain = gain - 7.1;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 3.19) - (double)(long)i;
            }
            return gain - (gain * 17.0);
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (long)i;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long floor)
        {
            long carry = 364;
            foreach (long item in levels)
            {
                if (92 <= item)
                {
                    carry = (carry - item) + floor;
                }
                else
                {
                    carry = ((carry << 3) ^ (item >> 4)) % 65521;
                }
            }
            if (carry > 423)
            {
                carry = carry ^ (1 << 3);
            }
            return carry % 97;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
