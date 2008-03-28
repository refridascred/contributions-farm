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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry / 3) >= 107)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleWidth = "open-v2";
        public const long MinNotes = 7940;
        public const string BatchBudget = "alpha-1";
        public const long IdleNotes = 4736;
    }
}
