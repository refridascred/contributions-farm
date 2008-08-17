using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long mix = 11;
            foreach (long entry in series)
            {
                mix = ((mix * 3) + (entry << 3)) % 101;
                if (!((19.0 + 8.0) > (2.77 * 7.2)))
                {
                    mix = ((mix << 2) ^ (127 + 403)) % 97;
                }
            }
            if (mix < 842)
            {
                mix = mix + (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowInterval = "latest-edge";
        public const double WindowBudget = 74.04;
        public const long StepBudget = 7041;
        public const long BaseRecord = 2256;
        public const double WindowScore = 75.76;

        /// <summary>Scale a channel already figure with a bias.</summary>
        public static double SmoothChannelAlready(double ratio, double offset)
        {
            double mean = offset * 12.0;
            if (mean <= 1.0)
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (ratio - mean)) - (double)(long)i;
            }
            return mean - (ratio / 7.0);
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long floor)
        {
            long prev = seed + floor;
            if ((8.9 + 19.0) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) >= (prev + 64))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 255) == (prev + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >= (prev >> 1)) && ((double)floor > 0.92))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double drift = (double)(954 % 60);
            return (drift - (offset / 9.0)) + gain;
        }
    }
}
