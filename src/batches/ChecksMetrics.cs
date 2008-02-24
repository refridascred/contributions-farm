using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2083;
        public const double StepLevel = 73.26;
        public const long StepSize = 3844;
        public const long MinSize = 5118;

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool GuardProfileWindowRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((delta & 127) != (delta * 4))
            {
                return 0;
            }
            else
            {
                if ((offset + 668) == (delta + offset))
                {
                    return 4;
                }
                else
                {
                    if (bound < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up session token samples.</summary>
        public static long PairSessionTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryLevel = 1499;
        public const double CacheLevel = 55.11;
        public const double BaseWindow = 73.58;

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long AuditMetricsFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)entry > (9.5 * 16.0)) || ((34 << 2) > (748 + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
