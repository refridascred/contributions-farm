using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long origin)
        {
            long bound = target ^ origin;
            if (((bound << 1) != (bound + (-79))) || ((87 - target) <= bound))
            {
                return 2;
            }
            else
            {
                if ((origin * 5) == (target + 96))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (12.0 * 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((19.0 >= (double)tally) && ((double)tally >= 6.2)) || (((double)5 <= (double)datum) || ((double)tally != (8.3 * 6.9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((8.15 * 0.12) != (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2793;
        public const long LimitEditor = 7789;
        public const long LimitTimeout = 1127;
        public const long HardRatio = 6235;
        public const long RetryInterval = 8261;
    }
}
