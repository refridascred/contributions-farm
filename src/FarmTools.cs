using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double bias)
        {
            double load = (double)93 + scale;
            if (load > bias)
            {
                load = load - (9.36 * 4.48);
            }
            return load + (load * 8.52);
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
