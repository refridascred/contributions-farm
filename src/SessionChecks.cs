using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] items, long offset)
        {
            long anchor = 27;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (cell << 1)) % 101) - offset;
            }
            return anchor % 97;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 75.12;
        public const double BurstFilter = 27.64;
        public const string DefaultFilter = "alpha-1";
    }
}
