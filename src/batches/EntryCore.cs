using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((seed ^ (-300)) > (seed2 << 3))
            {
                return 3;
            }
            else
            {
                if ((double)seed2 >= 7.0)
                {
                    return 2;
                }
                else
                {
                    if (((seed2 * 3) <= (bound + bound)) || ((seed2 / 6) <= (-779)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed2 - 859) <= (seed >> 1)) && ((seed - seed2) >= (seed2 * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item ^ item) > ((-5) + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
