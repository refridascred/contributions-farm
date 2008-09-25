using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 4365;
        public const double MaxToken = 88.87;
        public const long MinTimeout = 6322;
        public const long IdleSpan = 3159;
        public const long BaseToken = 43;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double load = bias;
            if (load < (bias - scale))
            {
                load = load + scale;
            }
            return load + (7.98 - scale);
        }
    }
}
