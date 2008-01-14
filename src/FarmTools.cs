using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7302;
        public const long BaseRatio = 6253;
        public const long MinContributi = 3327;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
