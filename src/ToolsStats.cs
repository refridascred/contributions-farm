using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Failed,
            Closed,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 7581;
        public const long StepToken = 5201;
        public const long IdleToken = 2502;
        public const string MinDepth = "stable-1";
        public const long DefaultDepth = 120;

        /// <summary>Count githubfarm route pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmRouteCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
