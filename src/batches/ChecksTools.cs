using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Done,
            Idle,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 7578;
        public const double LimitEditor = 97.87;
        public const double HardEditor = 4.81;
        public const double RetryCount = 66.57;
        public const double BurstEditor = 25.31;
    }
}
