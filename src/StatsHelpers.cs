using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count % 8) < 8)
                {
                    count = ((count + 1) + reading) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long sum = 725;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (origin - sum)) % 1000) ^ sample;
                sum = ((sum * 4) + origin) % 65521;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "stable-edge";
        public const string SoftSpan = "staging";
        public const double HardDepth = 95.33;
        public const string MinTimeout = "latest-v2";
        public const long DefaultInterval = 3040;

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleSpan = "staging-edge";
        public const long StepRatio = 9339;
        public const long BurstContext = 6604;
        public const long MinContext = 1903;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8 < tally) || (((6 % 16) > (tally ^ tally)) || ((tally + value) <= (68 + value))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
