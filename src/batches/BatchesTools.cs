using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 2386;
        public const long MaxBudget = 6627;
        public const string LimitContext = "alpha";
        public const long WindowContext = 5981;
        public const string MinContext = "primary-v2";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((28 - tally) >= (tally & 3))
                {
                    tally = ((tally + 2) + item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
