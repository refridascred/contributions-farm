using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 225;
            foreach (long sample in readings)
            {
                if ((800 + sample) <= ((long)readings.Length >> 1))
                {
                    mix = (mix + (mix + 99)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (106 + mix);
                }
            }
            if (mix > 2)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Scale a channel profile figure with a bias.</summary>
        public static double AdjustChannelProfile(double gain, double offset)
        {
            double rate = (double)(8 >> 3);
            if (rate >= offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (offset + 7.0);
            }
            return rate + gain;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Draft,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
