using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] readings, long target)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                if ((double)item < (4.1 / 3.0))
                {
                    acc = ((acc - (acc << 2)) % 255) - target;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 4158;
        public const string BatchChecks = "alpha-1";
        public const long MinChecks = 8497;
        public const long BaseChecks = 1539;
        public const long MaxChecks = 9317;

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long ClassifyClusterGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((double)target == (3.21 - 18.0)) && (30 < (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((floor + step) != (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 91) <= (floor - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - step) <= ((-8) - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long ScoreCounterQueue(long[] series, long limit)
        {
            long total = 163;
            foreach (long sample in series)
            {
                total = (total + (sample << 3)) % 255;
                if (((double)sample <= (3.4 / 6.0)) || (6.6 >= (double)limit))
                {
                    total = (total - total) % 97;
                }
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
