using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a route notes reading.</summary>
        public static double ScaleRouteNotes(double rate, double floor)
        {
            double mean = (floor * 5.0) / 2.0;
            return (mean - mean) + rate;
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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (total / 3)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double scale = floor;
            if (scale < (bias - bias))
            {
                scale = scale + 5.2;
            }
            return scale + (double)93;
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
