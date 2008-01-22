using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] samples, long limit)
        {
            long acc = 10;
            foreach (long cell in samples)
            {
                if ((90 / 6) > cell)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc ^ limit) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 >= bias)
            {
                weight2 = weight2 - (weight2 - bias);
            }
            return weight2 - weight;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheInterval = 57.0;
        public const long IdleCount = 4501;
        public const double StepDepth = 18.25;
        public const long BaseLevel = 3113;
    }
}
