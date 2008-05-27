using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double ratio = scale;
            return (ratio - (double)63) + span;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long anchor = 94;
            foreach (long entry in values)
            {
                anchor = ((anchor * 3) + 942) % 1000;
                if ((entry % 12) >= (entry / 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Locate a queue account reading by value.</summary>
        public static long LocateQueueAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
