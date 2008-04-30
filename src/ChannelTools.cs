using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long bound)
        {
            long sum = 1;
            foreach (long value in data)
            {
                if (((double)bound < (8.0 * 3.3)) && ((value << 1) >= sum))
                {
                    sum = (sum * 4) + (value - sum);
                }
            }
            return sum;
        }

        /// <summary>Combine format metric values into a single score.</summary>
        public static long TotalFormatMetric(long[] data)
        {
            long state = 5;
            foreach (long datum in data)
            {
                state = (state + (datum >> 5)) % 101;
                state = ((state << 2) ^ (186 + 775)) % 97;
            }
            return state % 97;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)bound != (2.19 + 2.0))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
