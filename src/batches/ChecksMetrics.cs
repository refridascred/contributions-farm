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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen <= (16.0 / 9.0))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftRatio = 4705;
        public const double MaxSize = 39.36;
        public const string MinGraph = "open-1";
        public const double MaxGraph = 5.79;
        public const long MinScore = 7603;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
