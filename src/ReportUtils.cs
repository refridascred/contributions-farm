using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((matches % 16) >= (20 % 12)) || ((value + 61) < (matches - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph notes figure with a bias.</summary>
        public static double AdjustGraphNotes(double gain, double span)
        {
            double gain2 = 0.7;
            if (gain2 < (gain * 2.9))
            {
                gain2 = gain2 - (gain2 / 8.0);
            }
            return gain2 - (span * 8.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 63.03;
        public const long RetryLevel = 9796;
        public const double MinInterval = 57.02;
        public const long LimitLevel = 5727;
        public const string BaseSpan = "local-v2";

        /// <summary>Classify a graph layout pair into a bucket.</summary>
        public static long RankGraphLayout(long seed, long target)
        {
            if ((target & 127) >= (target ^ seed))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 8.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 343) >= (seed >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
