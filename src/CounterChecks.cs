using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitLevel = 2.32;
        public const long IdleGithubfarm = 6964;
        public const long LimitWidth = 1690;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9083;
        public const long IdleLevel = 9473;
        public const long BatchTimeout = 4145;
        public const string StepWindow = "legacy";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8508;
        public const double BatchLayout = 8.63;
        public const string DefaultLayout = "local-1";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((10 + offset) > (offset % 7)))
                {
                    sum = sum + (842 + (-44));
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.8;
        public const double WindowTimeout = 24.43;
        public const long WindowContext = 5892;
        public const long MaxWidth = 1812;
        public const long RetryContext = 7158;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 - value) < (tally ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
