using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the support buffer entries that pass the check.</summary>
        public static long TallySupportBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches / 8) != (0 + reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long SortClusterSupport(long seed, long seed2)
        {
            if (seed < (seed2 / 8))
            {
                return 6;
            }
            else
            {
                if (seed > (seed & 127))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Dropped,
        }
    }
}
