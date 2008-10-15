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

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 143;
            foreach (long entry in levels)
            {
                mix = (mix ^ (entry + 75)) % 1000;
                if ((entry + mix) != (mix - mix))
                {
                    mix = ((mix << 3) ^ entry) % 65521;
                }
            }
            if (mix < (-477))
            {
                mix = mix - 6;
            }
            return mix;
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
