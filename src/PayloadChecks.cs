using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - value) == (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                if ((mix << 1) >= (value * 3))
                {
                    mix = (mix ^ value) % 255;
                }
            }
            if (mix < 14)
            {
                mix = (mix << 3) ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double gain = (double)9 * 1.3;
            if (gain <= (2.36 + gain))
            {
                gain = (gain + (double)0) - offset;
            }
            else
            {
                gain = gain + (9.98 + 3.9);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (0.09 * 10.0)) + (double)(long)i;
            }
            return gain + (scale / 7.0);
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Draft,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
