using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((-17) < (item >> 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double bias2)
        {
            double weight = (double)680 * 7.8;
            if (weight >= (double)127)
            {
                weight = (weight + (bias * 6.0)) + bias2;
            }
            else
            {
                weight = weight + (double)(-89);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight - 3.7)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 621;
        public const string LimitCache = "cached-v2";
        public const long HardWidth = 1090;
        public const long MinInterval = 7708;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long BucketAccountPayload(long offset, long step)
        {
            long edge = offset - step;
            if ((offset + edge) <= (edge / 2))
            {
                return 3;
            }
            else
            {
                if ((offset >> 3) >= ((-7) - offset))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
