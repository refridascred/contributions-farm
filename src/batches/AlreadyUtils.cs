using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (gain / 4.0)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "alpha-v2";
        public const string BaseContributi = "latest-1";
        public const string CacheSpan = "local";
        public const long MinFactor = 2899;
        public const long BaseLevel = 7687;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((limit + limit2) > (50 + 876))
            {
                return 7;
            }
            else
            {
                if (((limit2 << 2) <= limit2) || (((-8) + limit2) != (limit2 - limit)))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (limit2 - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.02 - 0.58) < (double)limit2) || ((double)limit2 <= (7.5 + 3.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (value & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
