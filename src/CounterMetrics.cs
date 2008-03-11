using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Rank entry record input into a small class.</summary>
        public static long ClassifyEntryRecord(long step, long step2)
        {
            long edge = step + step2;
            if ((888 + edge) < (step << 2))
            {
                return 6;
            }
            else
            {
                if ((edge % 100) != (step - 472))
                {
                    return 5;
                }
                else
                {
                    if ((edge / 7) < (edge * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Paused,
            Dropped,
            Done,
        }
    }
}
