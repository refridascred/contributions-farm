using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 7) <= (624 + count))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry >> 4) >= (limit + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - (long)samples.Length) < (sample << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally / 7) > (seed % 2)) && (31 > (tally & 3)))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (double)979)
            {
                rate = (rate - floor) + ratio;
            }
            else
            {
                rate = rate + (double)(-8);
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
