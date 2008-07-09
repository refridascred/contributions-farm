using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double ratio = 18.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio - (double)(long)i) + weight) + offset;
            }
            return ratio + (double)65;
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
