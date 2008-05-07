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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long seed)
        {
            long step2 = step - seed;
            if ((double)seed < (double)6)
            {
                return 1;
            }
            else
            {
                if (((step ^ seed) < step) && ((952 + step2) >= 7))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

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
