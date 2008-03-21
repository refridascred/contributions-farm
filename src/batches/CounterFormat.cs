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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long target)
        {
            long carry = 732;
            foreach (long value in samples)
            {
                carry = ((carry + (2 << 2)) + value) + target;
            }
            return carry % 1000;
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
