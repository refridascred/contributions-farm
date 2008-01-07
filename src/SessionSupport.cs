using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3952;
        public const long WindowFilter = 5945;
        public const string LimitWidth = "stable-v2";
        public const long SoftScore = 851;
        public const long DefaultFilter = 524;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool CheckToolsContributiRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
