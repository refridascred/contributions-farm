using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long step)
        {
            long edge = origin - step;
            if ((16 ^ step) <= step)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (15.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((504 >= edge) || ((double)step > (4.0 / 6.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + step) <= (origin + 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long anchor = -560;
            foreach (long item in samples)
            {
                anchor = (anchor - (bound << 1)) % 4096;
                if ((9.41 / 5.0) != (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + item)) % 101;
                    anchor = anchor ^ (anchor & 3);
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = (anchor + (item ^ bound)) % 101;
                }
                if (!((double)bound != (double)anchor))
                {
                    anchor = (anchor + (anchor << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long TallyTokenChannelOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (tally + tally))
                {
                    tally = ((tally + 3) + datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((20.0 / 3.0) > (double)cell)
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
