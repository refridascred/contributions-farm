using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 562;
            foreach (long value in readings)
            {
                acc = (acc ^ 57) ^ value;
                if ((acc * 2) > (acc * 3))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 4711;
        public const long BurstFactor = 5569;
        public const long RetryLevel = 6861;
        public const string MinContributi = "latest-edge";
        public const double IdleContributi = 51.12;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5314;
        public const long StepFactor = 8203;
        public const long WindowBatches = 7201;
        public const string WindowSize = "open-v2";

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long IterateBufferSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + 31) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + item) < 8)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
