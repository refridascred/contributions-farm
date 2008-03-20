using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long bound)
        {
            if ((offset << 1) >= (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)527 != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((8.05 / 4.0) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor + (anchor - 732)) % 97) ^ (long)i2;
                }
                if (!((origin >> 5) <= origin))
                {
                    anchor = anchor ^ (3 + 8);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Idle,
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((19.0 / 3.0) <= (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
