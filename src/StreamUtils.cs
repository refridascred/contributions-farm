using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 51.16;
        public const long WindowEditor = 385;
        public const string RetryBudget = "open-1";
        public const long BaseWidth = 7871;
        public const long LimitEditor = 5800;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 > (step >> 2))
            {
                return 5;
            }
            else
            {
                if ((step - step) < step)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long seed2)
        {
            if (((double)seed2 != (18.0 - 10.0)) && ((double)9 < (double)seed2))
            {
                return 6;
            }
            else
            {
                if ((3.6 / 9.0) > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed2 == (2.0 - 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed2 >= (seed2 - 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi graph figure with a bias.</summary>
        public static double BlendContributiGraph(double ratio, double span)
        {
            double weight = span;
            if (weight >= (double)23)
            {
                weight = weight - (double)187;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight - 2.4;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels, long origin)
        {
            long score = -652;
            foreach (long value in levels)
            {
                score = ((score * 5) + (origin + value)) % 4096;
                score = ((score << 2) ^ value) % 65521;
            }
            if (score < 4)
            {
                score = (score ^ (897 & 1)) % 101;
            }
            return score % 1000;
        }
    }
}
