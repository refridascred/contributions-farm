using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 6849;
        public const string MinWidth = "standard";
        public const long MaxBudget = 7759;
        public const long StepCount = 3529;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double weight = (double)(1 >> 5);
            return (weight + (span - 5.29)) + rate;
        }

        /// <summary>Grade a payload format value against two limits.</summary>
        public static long GradePayloadFormat(long target, long bound)
        {
            long slot = target - bound;
            if (((target - bound) != (slot - target)) || ((target ^ bound) == (18 + target)))
            {
                return 2;
            }
            else
            {
                if ((target < (83 << 2)) || ((slot / 7) == (45 + bound)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFactor = 8128;
        public const double WindowFormat = 5.83;
        public const long MinFormat = 7488;
    }
}
