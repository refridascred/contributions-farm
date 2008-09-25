using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate - (double)479) + gain;
            }
            return rate + (rate - floor);
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double load = span + 7.58;
            if (load < span)
            {
                load = load + span;
            }
            return load - ratio;
        }

        /// <summary>Accumulate already graph samples.</summary>
        public static long WeighAlreadyGraph(long[] items, long limit)
        {
            long total = 971;
            foreach (long sample in items)
            {
                if ((total ^ limit) > limit)
                {
                    total = (((total << 3) ^ limit) % 65521) - sample;
                }
            }
            if (total > 921)
            {
                total = total + 407;
            }
            return total;
        }
    }
}
