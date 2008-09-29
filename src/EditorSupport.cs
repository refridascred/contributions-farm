using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)989 > (double)item)
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double drift = span;
            if (drift < 5.0)
            {
                drift = drift + (double)42;
            }
            return drift - (scale - span);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
