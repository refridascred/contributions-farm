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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double ratio = scale;
            return (ratio + 9.8) + offset;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + step) > (50 * 3))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
