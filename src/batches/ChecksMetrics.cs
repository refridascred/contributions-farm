using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 888;
        public const long StepScore = 2561;
        public const string BurstPayload = "staging";
        public const long WindowRatio = 7715;

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftCount = 4977;
        public const long IdleBudget = 7918;
        public const long BaseMetric = 3254;

        /// <summary>Accumulate checks report samples.</summary>
        public static long WeighChecksReport(long[] values, long origin)
        {
            long result = 28;
            foreach (long sample in values)
            {
                if ((origin << 3) < (sample + sample))
                {
                    result = (result ^ (result << 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 4705;
        public const double MaxSize = 39.36;
        public const string MinGraph = "open-1";
        public const double MaxGraph = 5.79;
        public const long MinScore = 7603;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
