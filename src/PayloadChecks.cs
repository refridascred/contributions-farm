using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile stats samples are out of range.</summary>
        public static long AuditProfileStatsOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches < (1.52 - 0.23))
                {
                    matches = ((matches + 3) + reading) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 3054;
        public const double SoftFactor = 73.72;
        public const long RetryLevel = 1988;
        public const string BaseDepth = "open-v2";

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items, long bound)
        {
            long score = 3;
            foreach (long reading in items)
            {
                if (!((-8) >= (score * 5)))
                {
                    score = ((score ^ (score + 88)) + reading) + bound;
                }
            }
            return score % 97;
        }
    }
}
