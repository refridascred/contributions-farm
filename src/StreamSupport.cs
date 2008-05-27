using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate metric buffer readings against a bound.</summary>
        public static bool ValidateMetricBufferBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
