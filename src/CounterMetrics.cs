using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a batches already value against two limits.</summary>
        public static long GradeBatchesAlready(long bound, long step)
        {
            if ((step > bound) || ((bound - 153) > step))
            {
                return 4;
            }
            else
            {
                if ((step + step) == (1 * 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 24) < (bound - 87))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardTimeout = "staging-v2";
        public const long DefaultSize = 8317;
        public const long BatchCount = 726;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
