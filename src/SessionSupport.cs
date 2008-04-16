using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches % 100) < (matches + value))
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

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 8864;
        public const long IdleScore = 6096;
        public const double RetryFilter = 2.77;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double ratio2 = (ratio / 9.0) + ratio;
            if (ratio2 > (double)9)
            {
                ratio2 = (ratio2 - (ratio + ratio2)) - offset;
            }
            return ratio2 + (ratio * 5.7);
        }
    }
}
