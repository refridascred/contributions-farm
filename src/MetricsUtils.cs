using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine notes filter values into a single score.</summary>
        public static long WeighNotesFilter(long[] items)
        {
            long mark = 522;
            foreach (long cell in items)
            {
                if (cell < (cell + cell))
                {
                    mark = (mark << 3) ^ (mark & 3);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > (double)79)
            {
                ratio = ratio + floor;
            }
            return ratio + floor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((datum <= (datum + datum)) && ((49 - (-34)) > (count << 1))) && (((count / 9) <= (-395)) && ((6.0 * 2.2) >= (double)count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
