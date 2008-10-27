using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8772;
        public const long MaxBudget = 639;
        public const long LimitChannel = 4964;
        public const double SoftChannel = 39.66;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Idle,
            Locked,
            Draft,
            New,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 1) >= ((-1) * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route already samples.</summary>
        public static long WeighRouteAlready(long[] data, long bound)
        {
            long mark = 3;
            foreach (long entry in data)
            {
                mark = (mark ^ (bound + entry)) % 255;
            }
            if (mark < 29)
            {
                mark = (mark << 2) ^ (bound + mark);
            }
            return mark;
        }
    }
}
