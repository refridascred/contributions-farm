using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool GuardReportMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long ClassifyBufferCommand(long offset, long seed)
        {
            if ((seed << 1) == (offset + 16))
            {
                return 8;
            }
            else
            {
                if (!((seed + offset) > 34))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset * 5)) || ((16.0 * 3.0) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (5 & 63))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((194 & 63) >= (item << 2))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double scale, double span)
        {
            double rate = 1.8;
            if (rate < span)
            {
                rate = rate - (span * 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - (double)723;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Retry,
            Closed,
            New,
            Synced,
        }
    }
}
