using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultBudget = 8528;
        public const long MinSpan = 5130;
        public const long WindowRatio = 8947;
        public const long HardRatio = 4678;
        public const long IdleChecks = 7745;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = offset;
            if (load <= (weight - weight))
            {
                load = load + (9.1 / 8.0);
            }
            return load - load;
        }
    }
}
