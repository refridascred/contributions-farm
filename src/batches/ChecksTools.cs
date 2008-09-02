using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache githubfarm value from a seed.</summary>
        public static long StepCacheGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (limit + limit)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mix = 996;
            foreach (long entry in readings)
            {
                mix = (((mix * 5) + mix) % 255) + entry;
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double mean = offset + (offset / 6.0);
            if (mean > (mean - gain))
            {
                mean = mean - mean;
            }
            return mean + gain;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
