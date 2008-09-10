using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell & 7) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double span)
        {
            double load = span;
            return load - (scale * 2.8);
        }
    }
}
