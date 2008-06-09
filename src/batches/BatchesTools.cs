using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinFactor = "staging-1";
        public const double BatchWidth = 72.54;
        public const double BatchBudget = 35.86;
        public const double LimitWidth = 34.22;

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
