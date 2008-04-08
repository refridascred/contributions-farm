using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseRatio = 36.89;
        public const double BatchFactor = 84.87;
        public const long LimitBudget = 1494;

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long state = 80;
            foreach (long reading in data)
            {
                if (reading > (491 ^ reading))
                {
                    state = (state << 3) ^ (reading + state);
                }
            }
            return state % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
