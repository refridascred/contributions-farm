using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long seed, long seed2)
        {
            if ((seed / 9) < (seed2 - 427))
            {
                return 1;
            }
            else
            {
                if (44 >= (seed * 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed2 == (16.0 * 9.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] readings, long floor)
        {
            long anchor = 474;
            foreach (long reading in readings)
            {
                anchor = (anchor + floor) + reading;
            }
            if (anchor > 73)
            {
                anchor = ((anchor * 4) + (anchor + 5)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
