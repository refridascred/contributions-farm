using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Grade a checks buffer value against two limits.</summary>
        public static long ClassifyChecksBuffer(long origin, long seed)
        {
            if ((seed / 6) > 0)
            {
                return 2;
            }
            else
            {
                if ((origin & 1) == (seed - 11))
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((double)hits != (double)(-86)) || (((-755) & 63) == (hits & 255))) && ((20.0 / 6.0) > (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
