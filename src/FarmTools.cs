using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context already values into a single score.</summary>
        public static long CombineContextAlready(long[] values, long target)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = (score + (target / 7)) ^ item;
            }
            return score;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
