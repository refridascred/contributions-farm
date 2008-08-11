using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5659;
        public const double RetryGraph = 80.73;
        public const long MaxGraph = 2149;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long origin)
        {
            long carry = 838;
            foreach (long cell in data)
            {
                if ((double)carry >= 9.0)
                {
                    carry = (((carry * 2) + (carry & 3)) % 255) - cell;
                }
            }
            if (carry < 6)
            {
                carry = ((carry * 2) + origin) % 101;
            }
            return carry;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (11.0 / 9.0))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
