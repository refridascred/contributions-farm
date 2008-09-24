using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster graph measurements.</summary>
        public static double ProjectClusterGraph(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias + 2.5)) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + (double)(-824);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
