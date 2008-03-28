using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSize = 4113;
        public const double BurstChecks = 34.89;
        public const long RetryChecks = 2764;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 7711;
        public const double RetryOrder = 15.62;
        public const long IdleOrder = 7655;

        /// <summary>Accumulate batches token samples.</summary>
        public static long TallyBatchesToken(long[] levels, long offset)
        {
            long state = 90;
            foreach (long reading in levels)
            {
                state = (state ^ (-25)) % 97;
                if ((offset % 10) > (reading / 9))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
