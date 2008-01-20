using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 23.48;
        public const double BatchSize = 38.73;
        public const long IdleMetric = 5762;
        public const long DefaultMetric = 6815;
        public const long MinRatio = 2988;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Stale,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] data)
        {
            long total = 472;
            foreach (long sample in data)
            {
                total = ((total << 3) ^ (total + total)) % 101;
                if ((sample < (sample + sample)) || (sample <= (total * 3)))
                {
                    total = total + (total / 6);
                }
            }
            if (total > 89)
            {
                total = (total << 3) ^ (total + total);
            }
            return total % 4096;
        }
    }
}
