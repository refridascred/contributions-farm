using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading + (-85)) > (0 >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 2359;
        public const long LimitMetrics = 2056;
        public const long BaseScore = 538;
        public const long IdleMetrics = 7038;

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 87.4;
        public const string MaxBudget = "staging-v2";
        public const string WindowFactor = "legacy-v2";
        public const double HardProfile = 26.77;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long target)
        {
            long next = seed - target;
            if (((4 - next) <= 3) || ((target / 7) <= seed))
            {
                return 7;
            }
            else
            {
                if (((double)next != (6.17 - 9.83)) || ((next - next) < next))
                {
                    return 2;
                }
                else
                {
                    if (((target - 5) < target) || ((double)seed >= 9.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.7 + 1.0) != (double)next)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Closed,
            Done,
        }
    }
}
