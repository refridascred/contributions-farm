using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset + result) == (result << 3))
                {
                    result = (result + (offset & 15)) % 65521;
                }
                result = (result + (result >> 1)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((3.3 * 0.9) > (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 64.42;
        public const string MaxFactor = "legacy-1";
        public const long LimitBudget = 3659;
        public const long StepBatch = 5783;
    }
}
