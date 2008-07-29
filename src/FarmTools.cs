using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 1581;
        public const long HardRecord = 4599;
        public const long StepRecord = 9299;
        public const long BatchRecord = 4754;
        public const long LimitRecord = 3938;
    }
}
