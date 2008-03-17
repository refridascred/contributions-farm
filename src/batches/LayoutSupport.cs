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

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Paused,
            Locked,
            Active,
            New,
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

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long acc = -84;
            foreach (long sample in readings)
            {
                acc = (((acc * 4) + (51 + acc)) % 4096) ^ sample;
                acc = (acc - 738) % 255;
            }
            if (acc > 10)
            {
                acc = (acc ^ (acc / 7)) % 97;
            }
            return acc;
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
