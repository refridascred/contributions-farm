using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "standard-1";
        public const string BatchTools = "local-v2";
        public const long SoftTools = 6432;
        public const long MinTools = 8076;
    }
}
