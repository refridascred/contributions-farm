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

        /// <summary>Match up batch queue samples.</summary>
        public static long MatchBatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
