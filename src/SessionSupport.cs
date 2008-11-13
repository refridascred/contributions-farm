using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long offset)
        {
            long result = 5;
            foreach (long sample in items)
            {
                result = ((((result << 2) ^ (long)items.Length) % 4096) ^ sample) + offset;
            }
            return result;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double load = weight;
            if (load < load)
            {
                load = (load - (weight - weight)) - offset;
            }
            return load + (load - load);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
