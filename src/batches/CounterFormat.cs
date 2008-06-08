using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a layout queue pair into a bucket.</summary>
        public static long ClassifyLayoutQueue(long offset, long seed)
        {
            long edge = offset + seed;
            if (seed > (seed << 1))
            {
                return 5;
            }
            else
            {
                if (!((edge >> 1) == (offset * 4)))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (edge ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge ^ edge) <= edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
