using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double span)
        {
            double load = 3.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (load - gain)) + (double)(long)i) + span;
            }
            return load - (double)184;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
