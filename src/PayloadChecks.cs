using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long origin)
        {
            long score = 552;
            foreach (long value in levels)
            {
                score = score + (origin + score);
                if (((origin << 3) != (value + origin)) || ((double)score != (3.29 * 5.4)))
                {
                    score = (score + origin) % 4096;
                }
                if ((5 >> 4) <= score)
                {
                    score = (score - (score % 16)) % 1000;
                }
                if (score <= (value + score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Iterate the graph metrics series from a seed.</summary>
        public static long RollGraphMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (offset <= (long)i)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftCount = 34.13;
        public const long WindowFilter = 3421;
        public const long StepTimeout = 7677;
        public const double DefaultFilter = 63.35;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
