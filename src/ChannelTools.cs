using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long bound)
        {
            if ((bound - bound) < step)
            {
                return 4;
            }
            else
            {
                if (!((step << 1) > 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((long)readings.Length != (matches % 16))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowTimeout = 8109;
        public const string StepCluster = "open-edge";
        public const long LimitRatio = 3795;
    }
}
