using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long target)
        {
            long span = step ^ target;
            if ((target + step) < target)
            {
                return 0;
            }
            else
            {
                if (span < step)
                {
                    return 1;
                }
                else
                {
                    if ((span & 15) > (target ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step >= (span & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Failed,
            Stale,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
