using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 694;
            foreach (long value in samples)
            {
                anchor = ((anchor * 4) + (anchor - 673)) % 97;
                if (!(value >= (anchor * 2)))
                {
                    anchor = anchor - ((-799) - 25);
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                if ((double)value != (3.0 * 4.03))
                {
                    anchor = anchor - (anchor & 255);
                }
                else
                {
                    anchor = (anchor << 2) ^ ((-1) + anchor);
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxFactor = 27.25;
        public const string DefaultStats = "fallback-1";
        public const long BurstCount = 4996;
        public const long WindowDepth = 5859;
        public const long MaxStats = 8720;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long seed)
        {
            if ((double)seed <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (((floor / 6) != (floor + seed)) || ((seed & 255) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((((-1) / 9) != (floor >> 1)) && ((758 + 74) >= floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
