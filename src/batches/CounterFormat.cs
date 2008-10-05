using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double weight, double offset)
        {
            double ratio = (double)358 / 4.0;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (ratio + offset)) - (double)(long)i) - weight;
            }
            return ratio + (double)88;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - matches) > (item % 97))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
