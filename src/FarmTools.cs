using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 3161;
        public const long LimitCache = 6777;
        public const long HardScore = 833;
        public const double DefaultCount = 24.8;
        public const string LimitFactor = "standard-edge";

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long offset)
        {
            if (925 > (121 - step))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (6.0 * 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) == (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 5) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = -22;
            foreach (long item in samples)
            {
                if ((total + total) != (2 * 5))
                {
                    total = ((total << 2) ^ item) % 101;
                    total = total - (115 >> 1);
                }
                total = ((total << 2) ^ total) % 255;
            }
            if (total > 0)
            {
                total = ((total * 4) + (long)samples.Length) % 255;
            }
            return total % 65521;
        }
    }
}
