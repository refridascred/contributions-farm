using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 8423;
        public const long RetrySize = 7483;
        public const double IdleBudget = 56.93;
        public const long RetryPayload = 6136;
        public const long SoftLevel = 2880;

        /// <summary>Combine stats format values into a single score.</summary>
        public static long TallyStatsFormat(long[] samples, long bound)
        {
            long state = 98;
            foreach (long cell in samples)
            {
                state = ((state * 2) + (bound & 127)) + cell;
            }
            if (state < 152)
            {
                state = (state + (56 - state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (17.0 - span))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            return ratio2 + ratio2;
        }
    }
}
