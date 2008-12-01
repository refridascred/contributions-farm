using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long target)
        {
            long bound = origin ^ target;
            if (bound > (origin << 1))
            {
                return 7;
            }
            else
            {
                if (!((double)origin != (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= 8.45)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 4) > (19 / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Derive the next route commits value from a seed.</summary>
        public static long DeriveRouteCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
