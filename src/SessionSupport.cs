using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Idle,
            Closed,
            Draft,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowBudget = 6748;
        public const double BurstInterval = 18.81;
        public const long MinTimeout = 8239;
        public const string SoftSpan = "open";
        public const long BurstLevel = 2738;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
