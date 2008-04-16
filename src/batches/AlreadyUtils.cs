using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long bound)
        {
            if ((13.0 - 3.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (offset > (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 6623;
        public const long SoftStats = 5941;
        public const double MaxBudget = 21.7;

        /// <summary>Count the route window entries that pass the check.</summary>
        public static long TallyRouteWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0.7 - 4.42) < (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
