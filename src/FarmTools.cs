using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate schema buffer readings against a bound.</summary>
        public static bool CheckSchemaBufferBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Ready,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 72.97;
        public const long HardCommits = 4641;
        public const long HardCount = 592;
        public const long LimitScore = 1733;
        public const long IdleLevel = 209;
    }
}
