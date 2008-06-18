using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((double)prev != (4.4 / 3.0))
            {
                return 3;
            }
            else
            {
                if (((target - prev) >= (88 / 6)) || (prev > 945))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long step)
        {
            long anchor = 615;
            foreach (long entry in readings)
            {
                if (step < ((-942) - 1))
                {
                    anchor = anchor - (entry ^ step);
                }
            }
            if (anchor > 433)
            {
                anchor = (anchor * 3) + (anchor + 77);
            }
            return anchor;
        }
    }
}
