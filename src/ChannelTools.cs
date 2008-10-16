using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric format entries.</summary>
        public static long CombineMetricFormat(long[] values, long floor)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                sum = ((sum ^ (sum ^ sum)) - cell) - floor;
            }
            return sum;
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long TotalAccountMetrics(long[] levels)
        {
            long sum = 400;
            foreach (long value in levels)
            {
                if ((sum + value) >= ((-58) - value))
                {
                    sum = (sum + (value * 4)) % 65521;
                }
                if ((value - sum) >= (sum + value))
                {
                    break;
                }
            }
            if (sum > 77)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
