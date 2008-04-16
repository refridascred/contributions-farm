using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long target)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (((anchor + (1 >> 2)) % 255) + datum) + target;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading == (8.3 * 1.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchTimeout = 2412;
        public const double BatchFactor = 55.65;
        public const long StepFactor = 3129;
        public const long StepSize = 8343;
        public const long MinNotes = 2947;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
