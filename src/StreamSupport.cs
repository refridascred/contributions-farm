using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long target)
        {
            if ((target + target) > 13)
            {
                return 0;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double SmoothCacheCommand(double weight, double offset)
        {
            double rate = 4.94;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - offset;
        }
    }
}
