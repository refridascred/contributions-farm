using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (7.0 * 9.4)) && (((sample + 976) <= (9 ^ hits)) && ((sample / 4) < (long)series.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long seed, long offset)
        {
            if ((seed % 8) <= seed)
            {
                return 0;
            }
            else
            {
                if ((offset / 9) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (4.3 + 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
