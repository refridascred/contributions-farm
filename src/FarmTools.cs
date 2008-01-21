using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (588 + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }
    }
}
