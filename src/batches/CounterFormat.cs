using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double bias = (offset - offset) * 0.26;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset / 5.0)) - (double)(long)i;
            }
            return bias + (weight / 7.0);
        }
    }
}
