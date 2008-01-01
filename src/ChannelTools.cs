using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double span)
        {
            double scale = span;
            return scale - gain;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session cache series from a seed.</summary>
        public static long SeriesSessionCache(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = (total * 3) + (step / 9);
                total = (total + (step & 31)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
