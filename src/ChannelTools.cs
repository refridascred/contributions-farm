using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a account graph reading by value.</summary>
        public static long LookupAccountGraphIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((846 ^ entry) != (count & 31))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 1655;
        public const long BatchLevel = 426;
        public const long DefaultTimeout = 1269;
        public const long BaseCount = 9397;
    }
}
