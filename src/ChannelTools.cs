using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double scale, double span)
        {
            double weight = scale * 14.0;
            if (weight < (double)97)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + 9.2;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + 5) <= (769 << 1))
                {
                    count = ((count + 2) ^ entry) + origin;
                }
            }
            return count;
        }
    }
}
