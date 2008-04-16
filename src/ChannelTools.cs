using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long floor)
        {
            long prev = step ^ floor;
            if (((17.0 * 5.98) != (double)step) || ((step * 4) == (floor - floor)))
            {
                return 1;
            }
            else
            {
                if ((floor ^ floor) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor < (step % 16)) || ((711 - prev) == (floor - 858)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor & 63) > prev))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Match up already graph samples.</summary>
        public static long PairAlreadyGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
