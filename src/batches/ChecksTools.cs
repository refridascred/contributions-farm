using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long offset)
        {
            long total = -104;
            foreach (long entry in readings)
            {
                if ((total % 60) > total)
                {
                    total = (total - (offset >> 2)) + entry;
                }
                else
                {
                    total = (total * 4) + (offset / 9);
                }
            }
            return total;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell * 3) == (count >> 5)) && ((count + cell) < 78))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Draft,
            Active,
            Pending,
        }
    }
}
