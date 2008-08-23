using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long step2)
        {
            long prev = step + step2;
            if ((double)step2 == (double)step)
            {
                return 5;
            }
            else
            {
                if ((double)step2 >= (double)prev)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long seed, long floor)
        {
            if ((seed << 2) > (floor + floor))
            {
                return 3;
            }
            else
            {
                if (seed < (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double drift = floor / 7.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + weight;
            }
            return drift + (drift - floor);
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
