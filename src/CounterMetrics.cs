using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double span)
        {
            double gain = scale / 7.0;
            if (gain > (scale / 7.0))
            {
                gain = (gain + (double)2) - span;
            }
            else
            {
                gain = gain + (11.0 - gain);
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double ratio, double floor)
        {
            double weight = (double)(5 & 255);
            if (weight >= (double)517)
            {
                weight = weight - (double)759;
            }
            else
            {
                weight = weight + (ratio - floor);
            }
            return weight + ratio;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
