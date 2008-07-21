using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long floor)
        {
            if ((floor - limit) >= floor)
            {
                return 2;
            }
            else
            {
                if ((floor % 24) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
