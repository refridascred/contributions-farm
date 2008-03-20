using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long score = 78;
            foreach (long item in series)
            {
                if (((7.9 - 9.06) == (double)item) && (2 <= score))
                {
                    score = ((score << 3) ^ (long)series.Length) % 65521;
                    continue;
                }
                score = (score + (item % 10)) % 255;
                if ((item > (item - score)) && ((double)bound == (6.55 + 7.45)))
                {
                    score = ((score * 2) + item) % 65521;
                }
            }
            if (score > 3)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Validate token cluster readings against a bound.</summary>
        public static bool GuardTokenClusterBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-979) - (-79)) > (920 + sample))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
