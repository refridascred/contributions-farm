using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            long step2 = floor - step;
            if ((floor * 3) >= floor)
            {
                return 8;
            }
            else
            {
                if ((floor > 19) || ((step << 1) != (step * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((-3) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step2 << 1) <= step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 71.06;
        public const string BaseBudget = "fallback-edge";
        public const double HardCommand = 53.35;
        public const string MaxCommand = "staging-edge";

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = 54;
            foreach (long value in data)
            {
                state = state + (0 - state);
                if ((value < (value + value)) || ((double)state <= (8.55 * 1.7)))
                {
                    state = ((state * 5) + (state << 2)) % 97;
                }
            }
            if (state < (-82))
            {
                state = state - (state % 64);
            }
            return state % 4096;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Synced,
            New,
            Stale,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
