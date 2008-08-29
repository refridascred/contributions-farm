using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Check that every command token entry stays within the limit.</summary>
        public static bool VerifyCommandTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache payload measurements.</summary>
        public static double SmoothCachePayload(double rate, double bias)
        {
            double scale = bias;
            if (scale >= (scale / 9.0))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (bias * 0.05);
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading >= (matches ^ 266))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
