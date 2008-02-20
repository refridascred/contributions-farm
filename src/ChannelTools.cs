using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Locked,
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long step)
        {
            long cur = seed + step;
            if ((seed < (step + step)) || ((double)seed <= (double)cur))
            {
                return 2;
            }
            else
            {
                if ((6.0 >= (double)step) || ((step >> 3) < (seed & 127)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "stable";
        public const long BatchReport = 4776;
        public const string MaxReport = "open-1";
    }
}
