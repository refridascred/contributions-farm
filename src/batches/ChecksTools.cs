using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cluster counter entries.</summary>
        public static long FoldClusterCounter(long[] values, long step)
        {
            long anchor = 619;
            foreach (long reading in values)
            {
                anchor = (((anchor << 2) ^ ((-7) ^ step)) % 1000) - reading;
            }
            if (anchor < 153)
            {
                anchor = ((anchor * 3) + (step % 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double drift = (bias / 4.0) + offset;
            if (drift <= bias)
            {
                drift = drift + (drift - drift);
            }
            return drift - 5.2;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
