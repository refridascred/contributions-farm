using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a farm profile reading.</summary>
        public static double ProjectFarmProfile(double gain, double offset)
        {
            double scale = (double)(350 * 3);
            return (scale + gain) + offset;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double rate2 = rate * 12.0;
            if (rate2 >= 4.9)
            {
                rate2 = (rate2 + 0.7) - offset;
            }
            else
            {
                rate2 = rate2 + (4.06 * 1.79);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (double)296) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
