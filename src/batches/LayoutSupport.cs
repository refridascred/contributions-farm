using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                mix = (((mix << 2) ^ (766 << 1)) % 97) ^ cell;
            }
            if (mix < 430)
            {
                mix = ((mix << 3) ^ (914 << 3)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double scale, double span)
        {
            double rate = (span / 7.0) - 3.5;
            if (rate > span)
            {
                rate = rate + span;
            }
            else
            {
                rate = rate - scale;
            }
            return rate - (rate / 5.0);
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Paused,
            Retry,
            Closed,
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
