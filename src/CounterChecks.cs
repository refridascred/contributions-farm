using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((origin >> 4) != (origin * 4))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route payload input into a small class.</summary>
        public static long ClassifyRoutePayload(long floor, long origin)
        {
            long lane = floor + origin;
            if (!((lane * 3) != (origin >> 2)))
            {
                return 8;
            }
            else
            {
                if ((double)floor > (7.0 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((origin > floor) && ((floor - origin) == (lane & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryLevel = 8293;
        public const long HardSize = 8545;
        public const string DefaultCounter = "staging-v2";
        public const long MinBudget = 5350;
        public const long WindowBudget = 7227;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
