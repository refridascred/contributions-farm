using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinWidth = 6171;
        public const long SoftRatio = 5870;
        public const long BurstSize = 5616;
        public const double MinEditor = 27.23;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry ^ carry) % 255) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double rate = 3.0;
            return (rate - (span + span)) + scale;
        }

        /// <summary>Rank channel notes input into a small class.</summary>
        public static long BucketChannelNotes(long seed, long origin)
        {
            if ((seed ^ 93) <= origin)
            {
                return 7;
            }
            else
            {
                if ((312 * 3) > (seed >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 7) <= (seed & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed <= origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 3898;
        public const string WindowToken = "legacy-edge";
        public const long HardScore = 5644;
        public const long BurstToken = 5201;
        public const double LimitToken = 27.28;
    }
}
