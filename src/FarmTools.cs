using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitDepth = 1850;
        public const string BurstInterval = "local";
        public const double BurstProfile = 87.76;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items, long bound)
        {
            long mix = 749;
            foreach (long datum in items)
            {
                if (((datum & 3) == (datum + bound)) && ((double)bound <= (double)datum))
                {
                    mix = (mix << 3) ^ (bound << 1);
                }
            }
            if (mix < 226)
            {
                mix = mix + ((long)items.Length + bound);
            }
            return mix;
        }
    }
}
