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

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
