using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((double)tally < (10.0 * 9.66)) && ((6.0 - 6.7) < (double)value)) || ((tally ^ 883) > ((long)samples.Length % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mark = 20;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((long)levels.Length + mark))
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                else
                {
                    mark = ((mark * 3) + (reading - reading)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBudget = 51.48;
        public const double BatchSize = 37.1;
        public const long LimitTimeout = 9362;
        public const long BaseBuffer = 5442;
        public const double RetrySize = 57.61;
    }
}
