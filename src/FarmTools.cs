using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double scale2 = scale + (scale - bias);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale + scale2)) + (double)(long)i;
            }
            return scale2 - (scale - 2.3);
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
