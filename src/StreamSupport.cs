using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((((-98) + step) <= offset) || (offset >= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) == (offset - 4))
                {
                    return 6;
                }
                else
                {
                    if (offset < (step - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset + 5) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Dropped,
            Closed,
            Locked,
            Stale,
        }
    }
}
