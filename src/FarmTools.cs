using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 7606;
        public const string LimitGraph = "local-edge";
        public const long HardCount = 6809;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter account entries that pass the check.</summary>
        public static long TallyCounterAccountGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((floor >> 4) > (value + (-1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
