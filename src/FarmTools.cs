using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultScore = 6421;
        public const double BurstSession = 24.74;
        public const long IdleSession = 7118;
        public const long BaseFactor = 4236;
        public const double LimitScore = 42.07;

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftFactor = "legacy";
        public const double BaseRecord = 76.32;
        public const long DefaultRecord = 9020;
    }
}
