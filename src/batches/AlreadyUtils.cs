using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double gain = weight / 5.0;
            if (gain >= weight)
            {
                gain = gain - (floor + gain);
            }
            return gain + (double)965;
        }

        /// <summary>Compare every pair of counter support readings.</summary>
        public static long PairCounterSupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally % 60) <= (cell & 1)) && (((tally + tally) > cell) && ((cell % 60) == (29 >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
