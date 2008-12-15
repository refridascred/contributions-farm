using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftScore = 2630;
        public const string LimitFilter = "cached";
        public const long BaseFilter = 8419;
        public const long StepRatio = 1092;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
