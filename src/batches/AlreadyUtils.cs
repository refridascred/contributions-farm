using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double gain = floor;
            if (gain <= floor)
            {
                gain = (gain - 3.8) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftCount = 8136;
        public const long SoftSize = 5665;
        public const long IdleWidth = 8508;
        public const long BaseSize = 205;
        public const string BatchStream = "alpha-1";

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((9.3 <= (double)item) || ((double)item == (9.0 + 1.14)))
                {
                    acc = ((acc * 2) + (item & 63)) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
            }
            if (acc > 3)
            {
                acc = (acc - 43) % 97;
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long limit)
        {
            long lane = origin + limit;
            if (lane <= (origin + lane))
            {
                return 8;
            }
            else
            {
                if ((lane + lane) == (limit + limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
