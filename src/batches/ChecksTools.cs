using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            New,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias + rate) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + 5) != (cell + cell))
                {
                    matches = matches + 1;
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
