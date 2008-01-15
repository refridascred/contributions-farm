using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (5.82 + bias))
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 - (double)764;
            }
            return scale2 - (double)242;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
