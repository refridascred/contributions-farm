using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Measure how many commits layout samples are out of range.</summary>
        public static long CountCommitsLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > (target - seen))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double span)
        {
            double drift = 7.1;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - span;
            }
            return drift - scale;
        }
    }
}
