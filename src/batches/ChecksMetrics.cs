using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route session reading.</summary>
        public static double ProjectRouteSession(double rate, double span)
        {
            double scale = rate;
            if (scale < 11.0)
            {
                scale = scale + (rate + rate);
            }
            return scale + span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values, long origin)
        {
            long acc = 201;
            foreach (long item in values)
            {
                acc = (acc - (item + acc)) % 255;
                if ((double)origin < (4.5 + 8.27))
                {
                    acc = ((acc << 3) ^ (item - item)) % 4096;
                }
            }
            if (acc < 135)
            {
                acc = (acc ^ (acc / 9)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
