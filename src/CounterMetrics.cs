using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the session cache entries that pass the check.</summary>
        public static long TallySessionCacheHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= (tally - tally))
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 50.27;
        public const long LimitGraph = 3818;
        public const long BaseLevel = 8333;
        public const long MaxGraph = 4060;
        public const long WindowGraph = 1226;

        /// <summary>Measure how many githubfarm layout samples are out of range.</summary>
        public static long TallyGithubfarmLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((9.0 * 5.5) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
