using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((8 & 7) != (step >> 2))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long bound, long offset)
        {
            if ((1.0 + 0.75) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (6.1 + 0.8))
                {
                    return 5;
                }
                else
                {
                    if ((2.4 + 1.8) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound == (3.9 / 4.0))
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

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
