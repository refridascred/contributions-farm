using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 23.49;
        public const long BaseDepth = 9501;
        public const long DefaultCount = 824;
        public const string BurstBuffer = "alpha-edge";
        public const long WindowDepth = 4844;
    }
}
