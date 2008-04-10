using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long bound)
        {
            long carry = -42;
            foreach (long item in data)
            {
                if (item > carry)
                {
                    carry = ((carry * 4) + (bound - carry)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxCount = 2386;
        public const long BaseBuffer = 4997;
        public const long MinBuffer = 7281;
        public const string CacheBuffer = "stable-edge";
        public const string CacheInterval = "latest";

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Idle,
            Locked,
            Draft,
            Active,
        }
    }
}
