using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double gain2 = floor - gain;
            if (gain2 <= 7.0)
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain - floor);
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
