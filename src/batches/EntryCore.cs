using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double scale = floor;
            if (scale > scale)
            {
                scale = (scale + 3.3) - weight;
            }
            else
            {
                scale = scale - (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)113;
        }

        /// <summary>Match up report token samples.</summary>
        public static long PairReportTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double load = (double)(14 + 700);
            if (load > (double)(-86))
            {
                load = load + load;
            }
            else
            {
                load = load - (ratio / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (double)94;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 938;
        public const long StepLevel = 3741;
        public const string CacheGithubfarm = "fallback-1";
        public const long BurstInterval = 504;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepScore = 1288;
        public const string StepCount = "latest-v2";
        public const long SoftStats = 9800;
    }
}
