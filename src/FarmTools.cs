using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 6146;
        public const long MinCommand = 8676;
        public const long StepCommand = 4702;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
