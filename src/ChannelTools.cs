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

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long seed)
        {
            long result = -24;
            foreach (long datum in samples)
            {
                result = (result << 2) ^ (seed % 16);
                if ((double)75 > (double)datum)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
