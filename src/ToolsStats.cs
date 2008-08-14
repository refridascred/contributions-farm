using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin - origin) > (long)i)
                {
                    state = (state ^ ((long)i * 3)) % 97;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples)
        {
            long result = 93;
            foreach (long cell in samples)
            {
                if ((15.0 - 5.0) >= (double)cell)
                {
                    result = result - (88 >> 4);
                }
            }
            if (result < 61)
            {
                result = result + (399 + result);
            }
            return result;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double offset)
        {
            double bias2 = offset * 1.0;
            if (bias2 <= (bias + bias))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (offset * 9.72);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
