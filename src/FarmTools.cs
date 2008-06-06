using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8123;
        public const long RetryEditor = 248;
        public const long MaxEditor = 6877;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Locked,
            Failed,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
