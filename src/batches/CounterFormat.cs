using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of channel window entries.</summary>
        public static long ScoreChannelWindow(long[] series, long step)
        {
            long carry = 654;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = carry + ((long)series.Length << 3);
                    carry = ((carry << 3) ^ (long)i) % 1000;
                }
                carry = carry + (datum * 3);
                if ((datum - carry) <= step)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every token cache entry stays within the limit.</summary>
        public static bool CheckTokenCacheLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double load = (double)(3 + 6);
            if (load > (double)2)
            {
                load = (load + (bias / 4.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 2.6;
        }
    }
}
