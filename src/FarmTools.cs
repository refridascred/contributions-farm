using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((offset * 5) < (67 & 255)) && ((offset ^ tally) != (tally / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7751;
        public const long LimitFactor = 1630;
        public const long BaseRatio = 7162;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
