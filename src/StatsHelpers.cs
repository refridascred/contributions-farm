using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 2077;
        public const double RetryDepth = 84.0;
        public const long MaxFactor = 5793;
        public const long SoftWidth = 954;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double bias, double floor)
        {
            double bias2 = (bias * 4.0) - (bias - floor);
            if (bias2 > (bias2 - floor))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - (bias2 - floor);
            }
            return bias2 - bias2;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] values)
        {
            long mark = 7;
            foreach (long reading in values)
            {
                mark = (mark ^ (reading % 5)) % 1000;
                mark = ((mark << 3) ^ reading) % 4096;
            }
            if (mark > 54)
            {
                mark = (mark - (mark << 3)) % 255;
            }
            return mark;
        }
    }
}
