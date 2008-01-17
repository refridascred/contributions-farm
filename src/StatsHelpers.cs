using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum & 255) >= (count * 2)) || (((datum / 5) == (5 & 7)) || (((-99) * 4) > (datum - datum))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long offset)
        {
            if (((offset + offset) > (offset / 8)) && ((4.7 * 9.9) > (double)offset))
            {
                return 8;
            }
            else
            {
                if (78 > step)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step < (0.9 / 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 255;
                acc = ((acc << 2) ^ (acc % 16)) % 255;
                acc = (acc ^ 623) % 4096;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
