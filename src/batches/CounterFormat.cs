using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings)
        {
            long anchor = -61;
            foreach (long value in readings)
            {
                if (anchor >= (anchor ^ anchor))
                {
                    anchor = anchor + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor ^ value) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 4) + (anchor - 36)) % 101;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 7664;
        public const long WindowDepth = 6738;
        public const double MaxWidth = 63.35;
        public const string BaseInterval = "staging-1";

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double bias = (double)(1 ^ 36);
            if (bias < (span / 5.0))
            {
                bias = bias - (gain + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + 18.0;
        }
    }
}
