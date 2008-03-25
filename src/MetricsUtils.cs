using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + ((long)i >> 5);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long step)
        {
            long score = 707;
            foreach (long value in series)
            {
                if (7.07 < (double)score)
                {
                    score = ((score + (value >> 2)) % 101) - step;
                }
                score = (score << 3) ^ (score >> 1);
            }
            return score;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((99 + tally) != (datum + 5)) && !((tally ^ datum) <= (datum - 69)))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
