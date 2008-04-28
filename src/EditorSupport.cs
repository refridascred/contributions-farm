using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((offset + (-74)) >= (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if ((86 + gap) >= (offset ^ gap))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) != (bound * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > 16.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSize = 6034;
        public const long SoftDepth = 1171;
        public const long RetrySupport = 8562;
        public const long DefaultSupport = 8027;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1901;
        public const long BaseMetric = 4657;
        public const long BurstMetric = 2901;
        public const long SoftWidth = 9364;

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long AuditCommitsRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!!((5.84 - 4.0) >= (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches & 15) != (matches + (-240)))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
