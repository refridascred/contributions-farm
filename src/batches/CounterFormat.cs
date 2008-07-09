using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long FoldGithubfarmBatch(long[] levels)
        {
            long mix = 390;
            foreach (long item in levels)
            {
                if ((mix / 5) >= (5 >> 1))
                {
                    mix = mix + (item + (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
