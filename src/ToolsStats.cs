using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Paused,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 2) ^ 68;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1113;
        public const double BaseWidth = 9.13;
        public const long BurstEntry = 698;
        public const long MinEntry = 1449;

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 4) + offset;
                long prev = (92 << 2) ^ (offset << 1);
                if ((double)offset < 9.36)
                {
                    sum = (sum << 3) ^ (prev * 4);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
