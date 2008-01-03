using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (double)9)
            {
                weight2 = (weight2 - (double)21) + weight;
            }
            return weight2 + bias;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length < (1.0 - 11.0))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
