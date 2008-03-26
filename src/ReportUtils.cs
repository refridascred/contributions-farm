using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double gain = rate - 6.1;
            if (gain < 1.2)
            {
                gain = (gain - (double)1) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (double)0) + (double)(long)i;
            }
            return gain - (double)921;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double gain2 = 6.38;
            if (gain2 >= gain)
            {
                gain2 = (gain2 - gain2) + bias;
            }
            else
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain - gain);
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long ScoreAlreadyGithubfarm(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((19.0 - 4.9) == (double)origin)
                {
                    sum = (sum ^ ((long)levels.Length + reading)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (5 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double floor)
        {
            double bias = (double)(988 ^ 11);
            return ((bias + bias) + ratio) + floor;
        }
    }
}
