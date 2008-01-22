using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = bias + (floor - floor);
            if (scale > 0.9)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale - (bias + bias);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] series, long offset)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = ((((carry << 3) ^ (26 % 10)) % 255) + entry) + offset;
            }
            return carry % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 8187;
        public const long BaseMetric = 7268;
        public const long BaseFactor = 4372;
        public const long MinSize = 9454;
        public const string WindowMetric = "fallback";

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                bool ok = !((offset - offset) == (total / 2));
                total = total + offset;
                if (ok)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                mix = mix + (datum % 24);
                if ((datum + offset) >= (datum ^ datum))
                {
                    mix = ((mix * 3) + 569) % 1000;
                    mix = mix - offset;
                }
                else
                {
                    mix = mix + (datum * 5);
                    mix = ((mix << 2) ^ (offset + mix)) % 255;
                }
                if ((15.0 * 5.0) < (double)mix)
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long target)
        {
            long state = 1;
            foreach (long reading in values)
            {
                if (state <= (reading * 5))
                {
                    state = (state ^ (reading >> 4)) + target;
                }
                state = (state - (reading - reading)) % 101;
            }
            return state % 4096;
        }
    }
}
