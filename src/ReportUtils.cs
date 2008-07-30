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

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8508;
        public const long MinEntry = 594;
        public const string HardEntry = "strict-1";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + mark) % 255;
                mark = (mark ^ (mark - (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 1192;
        public const double LimitScore = 16.21;
        public const long IdleCount = 5362;
        public const double IdleScore = 10.2;

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
