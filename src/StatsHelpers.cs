using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            if (floor <= (bound * 4))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (11.0 + 0.01)) || (bound <= floor))
                {
                    return 6;
                }
                else
                {
                    if (((double)floor == (double)30) && ((bound % 97) < (bound % 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + floor) >= (40 ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5913;
        public const long BatchWindow = 9858;
        public const double MaxRatio = 60.56;
        public const double StepWindow = 22.92;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long anchor = 85;
            foreach (long reading in samples)
            {
                anchor = (anchor << 3) ^ (34 + anchor);
                anchor = (anchor - reading) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Pending,
            Done,
        }
    }
}
