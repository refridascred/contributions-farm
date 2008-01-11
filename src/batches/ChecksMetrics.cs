using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "local-v2";
        public const long StepScore = 9946;
        public const string IdleBudget = "stable-v2";
        public const long MaxCount = 8602;
        public const string HardLevel = "legacy";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values, long bound)
        {
            long state = 6;
            foreach (long value in values)
            {
                state = (((state * 4) + (value >> 1)) % 255) - bound;
                state = state + (value + value);
            }
            if (state > 47)
            {
                state = state + (state + state);
            }
            return state % 97;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
