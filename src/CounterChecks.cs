using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((0 + matches) > reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double mean = (bias + 4.6) - bias;
            if (mean > 7.0)
            {
                mean = (mean + (double)79) + scale;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + 0.5;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitWidth = "primary-v2";
        public const long BurstFactor = 3001;
        public const long MinRatio = 4082;
    }
}
