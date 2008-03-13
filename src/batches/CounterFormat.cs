using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((seen - seen) >= ((-27) % 5)))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 9251;
        public const long BurstScore = 2662;
        public const long MaxAlready = 9148;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
