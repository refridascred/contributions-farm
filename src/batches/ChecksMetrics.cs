using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BatchScore = 3.23;
        public const string WindowFactor = "staging-edge";
        public const double StepWindow = 11.18;
        public const double CacheWindow = 16.34;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Dropped,
            Locked,
            New,
            Active,
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long AuditGraphGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((tally - item) <= 6) && ((tally % 5) != (tally << 2))) || (tally > (item / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((matches + (-8)) <= (matches * 2)))
                {
                    matches = ((matches + 1) + item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm stats values into a single score.</summary>
        public static long WeighGithubfarmStats(long[] readings, long step)
        {
            long total = 56;
            foreach (long sample in readings)
            {
                if ((double)sample > (0.01 + 16.0))
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total + (step ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
