using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 9577;
        public const long DefaultScore = 5586;
        public const long BaseScore = 4466;
        public const long LimitBuffer = 5021;
        public const long HardDepth = 6133;

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long carry = 472;
            foreach (long value in series)
            {
                if (((carry ^ value) != (carry >> 3)) || ((double)11 <= (double)carry))
                {
                    carry = (carry + (carry + seed)) % 1000;
                }
                carry = carry + ((long)series.Length + carry);
            }
            return carry;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double scale = (double)53 / 8.0;
            if (scale <= (scale / 8.0))
            {
                scale = (scale - gain) + span;
            }
            else
            {
                scale = scale + (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (gain * 16.0)) + (double)(long)i;
            }
            return scale - (double)4;
        }
    }
}
