using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 4) > tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 2213;
        public const long BaseStats = 2418;
        public const long BurstStats = 2304;
        public const double HardInterval = 22.3;

        /// <summary>Classify a stream window pair into a bucket.</summary>
        public static long GradeStreamWindow(long bound, long seed)
        {
            if ((12.0 + 8.2) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((seed + seed) < (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if (bound > (bound + 491))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound & 63) < seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                if ((double)0 < (double)sum)
                {
                    sum = ((sum * 3) + (-1)) + entry;
                }
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftFactor = 5218;
        public const string HardEditor = "standard-1";
        public const double StepInterval = 95.66;
        public const string BurstFactor = "latest";
        public const string WindowDepth = "alpha-v2";
    }
}
