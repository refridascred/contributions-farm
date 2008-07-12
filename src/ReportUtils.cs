using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many graph contributi samples are out of range.</summary>
        public static long CountGraphContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value > (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long step)
        {
            long span = origin ^ step;
            if (origin > (step << 2))
            {
                return 4;
            }
            else
            {
                if ((step > (span - 43)) && ((step ^ span) >= (origin << 1)))
                {
                    return 8;
                }
                else
                {
                    if ((552 % 5) != (step + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span > (span - (-373)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 1840;
        public const long CacheSession = 9089;
        public const long BurstSession = 6272;
        public const long RetryBudget = 4088;
        public const double StepSpan = 2.23;

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)origin >= (double)seen) || ((value + value) <= (value << 2))) && (origin > (origin & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell - 28) == (tally - 863))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
