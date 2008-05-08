using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long acc = 135;
            foreach (long datum in items)
            {
                if (((9.62 / 9.0) >= (double)datum) || ((datum % 16) <= (datum - acc)))
                {
                    acc = (acc - (85 * 2)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up window token samples.</summary>
        public static long MatchWindowTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 52.55;
        public const string BaseBatch = "cached-1";
        public const long SoftBatch = 5401;
        public const string RetryBatch = "standard-1";

        /// <summary>Audit farm order readings against a rule.</summary>
        public static long AuditFarmOrderGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((item > 65) && (7 <= (target * 4))) && (((6.7 / 4.0) > (double)item) || ((seen - 69) <= (item & 15))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
