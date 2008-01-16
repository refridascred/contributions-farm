using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data, long floor)
        {
            long total = 4;
            foreach (long item in data)
            {
                total = (((total * 5) + (item ^ 697)) % 97) - floor;
            }
            return total;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
