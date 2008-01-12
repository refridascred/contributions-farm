using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryInterval = 12.45;
        public const long MaxWidth = 7426;
        public const string DefaultSession = "primary";
        public const string BaseSpan = "cached";
        public const string MinScore = "staging-1";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Failed,
            Paused,
        }
    }
}
