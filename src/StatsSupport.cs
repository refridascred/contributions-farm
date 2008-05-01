using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2448;
        public const long CacheToken = 9843;
        public const double StepToken = 30.84;
        public const long LimitToken = 675;
        public const long MinToken = 3078;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long acc = 32;
            foreach (long entry in items)
            {
                acc = ((acc * 3) + acc) + entry;
                acc = (acc * 2) + (acc & 7);
            }
            if (acc < (-360))
            {
                acc = (acc * 2) + (4 + acc);
            }
            return acc;
        }
    }
}
