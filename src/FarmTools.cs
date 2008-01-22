using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 773;
        public const long StepStream = 6496;
        public const long SoftStream = 7690;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - floor) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
