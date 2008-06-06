using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8123;
        public const long RetryEditor = 248;
        public const long MaxEditor = 6877;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double weight, double offset)
        {
            double load = weight;
            if (load < (double)743)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
