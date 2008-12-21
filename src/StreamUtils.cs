using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two contributi queue measurements.</summary>
        public static double ScaleContributiQueue(double gain, double floor)
        {
            double rate = (floor - floor) * 1.47;
            if (rate >= (rate / 9.0))
            {
                rate = rate + (rate + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Active,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 4;
            foreach (long reading in series)
            {
                acc = acc - (reading - reading);
            }
            if (acc < 69)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (6.01 + rate))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long anchor = 13;
            foreach (long value in items)
            {
                if ((value - 1) == (value + anchor))
                {
                    anchor = ((anchor << 2) ^ (anchor ^ value)) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + value) % 65521;
                }
            }
            if (anchor > 643)
            {
                anchor = (anchor + (757 + (-93))) % 65521;
            }
            return anchor % 4096;
        }
    }
}
