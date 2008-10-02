using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double drift = bias;
            if (drift >= (drift - bias))
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (7.11 - bias)) + (double)(long)i;
            }
            return drift + (double)(-781);
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long bound)
        {
            long carry = 2;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (bound ^ 32)) ^ reading;
            }
            if (carry < 0)
            {
                carry = ((carry * 2) + (carry << 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((14 + entry) > (74 ^ anchor))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                if (4.09 < (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
