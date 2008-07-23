using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 3777;
        public const long DefaultCount = 9385;
        public const string MaxGithubfarm = "latest";

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double weight = (double)(496 + (-989));
            if (weight <= 5.43)
            {
                weight = (weight + bias2) - bias;
            }
            return weight + bias2;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long ScoreStreamCounter(long[] data, long bound)
        {
            long state = 885;
            foreach (long value in data)
            {
                if ((30 + value) >= (bound + 34))
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state ^ value) % 101;
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 29.61;
        public const double RetrySize = 46.97;
        public const long BatchRecord = 2475;
        public const long DefaultRecord = 7827;
        public const double StepSpan = 60.46;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long lane = seed - floor;
            if ((double)lane == (double)82)
            {
                return 7;
            }
            else
            {
                if (lane >= 445)
                {
                    return 8;
                }
                else
                {
                    if ((771 * 3) >= (8 ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(seed >= (floor % 12)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] values)
        {
            long state = 246;
            foreach (long entry in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + state) % 1000) + (long)i;
                }
                state = state + entry;
                state = state - (state << 2);
            }
            return state % 4096;
        }
    }
}
