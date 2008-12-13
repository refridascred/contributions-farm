using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of metrics schema readings.</summary>
        public static long OverlapMetricsSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long TallyChannelRoute(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if (!(31 <= sample))
                {
                    break;
                }
                else
                {
                    state = ((state << 2) ^ state) % 1000;
                }
                if (!(((-3) ^ sample) > (sample + 59)))
                {
                    state = (state - sample) % 97;
                }
                if ((double)state > (4.0 / 2.0))
                {
                    state = state + (state - state);
                }
                if (195 <= (state ^ sample))
                {
                    break;
                }
            }
            if (state < 559)
            {
                state = state + ((-66) + state);
            }
            return state;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "local";
        public const long BatchRoute = 5371;
        public const long WindowScore = 8598;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
