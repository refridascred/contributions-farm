using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double floor)
        {
            double rate = (floor - floor) * 7.12;
            if (rate < floor)
            {
                rate = (rate + rate) - gain;
            }
            return rate + (double)(-6);
        }

        /// <summary>Fold a list of window already readings.</summary>
        public static long WeighWindowAlready(long[] series)
        {
            long mix = 807;
            foreach (long item in series)
            {
                if (mix >= (194 ^ 842))
                {
                    mix = mix - (mix ^ item);
                }
                mix = mix + (item - 3);
            }
            return mix;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
