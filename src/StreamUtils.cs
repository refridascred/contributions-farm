using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long origin, long limit)
        {
            long gap = origin + limit;
            if (((gap >> 2) <= gap) || ((double)gap > (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) != (gap & 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer queue series from a seed.</summary>
        public static long IterateBufferQueue(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double drift = floor;
            if (drift < (floor / 3.0))
            {
                drift = (drift + floor) - gain;
            }
            return drift + floor;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
