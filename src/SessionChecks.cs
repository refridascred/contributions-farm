using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Pending,
            Closed,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 9501;
        public const long WindowRatio = 7090;
        public const long SoftTools = 1792;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)bound >= (double)4)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
