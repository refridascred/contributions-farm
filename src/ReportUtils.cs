using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long SeriesQueueContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((((-696) % 12) <= hits) && ((item + (-2)) < 0)) || !((item - hits) != (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + origin) < (matches ^ origin))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long offset)
        {
            long acc = 18;
            foreach (long sample in items)
            {
                if ((offset & 15) == (offset - 63))
                {
                    acc = acc + offset;
                    acc = (acc + (78 & 15)) % 255;
                }
                if (!((acc * 5) > sample))
                {
                    acc = acc ^ (sample + sample);
                }
            }
            return acc;
        }
    }
}
