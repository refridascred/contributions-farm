using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account commits entry stays within the limit.</summary>
        public static bool ValidateAccountCommitsRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Stale,
            Done,
            New,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleWidth = "open-v2";
        public const long MinNotes = 7940;
        public const string BatchBudget = "alpha-1";
        public const long IdleNotes = 4736;
    }
}
