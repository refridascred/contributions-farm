using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a notes order figure with a bias.</summary>
        public static double BlendNotesOrder(double ratio, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight + (weight + weight)) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)87) - (double)(long)i;
            }
            return weight - 5.4;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item / 4) > (hits << 1))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }
    }
}
