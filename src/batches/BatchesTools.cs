using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up graph already samples.</summary>
        public static long OverlapGraphAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseWidth = "alpha-1";
        public const long LimitFactor = 5864;
        public const long HardSession = 4718;
        public const double RetryDepth = 53.02;
        public const double MaxFactor = 62.4;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
