using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 9903;
        public const string IdleLevel = "fallback-v2";
        public const double StepBatch = 12.87;
        public const long SoftBatch = 2020;
        public const long RetryBatch = 7946;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum + seen) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            New,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (offset > (gap - floor))
            {
                return 5;
            }
            else
            {
                if (((floor + floor) != (offset ^ gap)) && ((6.2 - 2.18) >= (0.6 + 6.3)))
                {
                    return 2;
                }
                else
                {
                    if (38 < (gap ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.5 - 6.0) < (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                if ((sum % 60) == (datum + sum))
                {
                    sum = ((sum * 5) + (sum + 7)) % 97;
                }
            }
            if (sum < 34)
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }
    }
}
