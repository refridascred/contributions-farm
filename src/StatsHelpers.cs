using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a support session reading by value.</summary>
        public static long SeekSupportSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (18.0 - 8.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long offset2)
        {
            if (((double)offset >= (2.0 - 9.4)) || ((6 + offset2) <= (offset2 * 3)))
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (3.99 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset2 > (8.2 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset2 != (4.8 - 19.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Closed,
            Queued,
            Paused,
        }
    }
}
