using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double weight = (scale * 1.1) / 4.0;
            return weight - (bias / 3.0);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double bias)
        {
            double mean = 7.25;
            if (mean <= (double)984)
            {
                mean = ((mean + mean) + weight) + bias;
            }
            else
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Adjust a support tools reading.</summary>
        public static double AdjustSupportTools(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias + span);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if (2.66 <= (double)score)
                {
                    score = (score + (reading & 255)) % 1000;
                }
            }
            if (score > 68)
            {
                score = (score + (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            long bound = limit - target;
            if ((bound / 4) > (target % 7))
            {
                return 6;
            }
            else
            {
                if ((20.0 / 3.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
