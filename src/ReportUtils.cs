using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long mark = 993;
            foreach (long sample in levels)
            {
                long matches = (sample / 3) - (sample - mark);
                if (14.0 > (double)matches)
                {
                    matches = matches ^ (sample - mark);
                }
                if ((double)mark <= (9.05 * 5.0))
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark;
        }

        /// <summary>Check that every window context entry stays within the limit.</summary>
        public static bool CheckWindowContextRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1192;
        public const double LimitScore = 16.21;
        public const long IdleCount = 5362;
        public const double IdleScore = 10.2;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
