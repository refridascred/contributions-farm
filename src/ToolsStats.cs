using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = scale + gain;
            }
            return scale - (span / 5.0);
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double weight, double offset)
        {
            double load = (double)397 - (offset / 2.0);
            if (load >= load)
            {
                load = load - 4.1;
            }
            return load + weight;
        }

        /// <summary>Locate a context report reading by value.</summary>
        public static long LookupContextReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
