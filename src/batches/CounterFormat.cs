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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardCount = 7833;
        public const long DefaultCount = 6935;
        public const long WindowContributi = 7398;
        public const long HardContributi = 4197;
    }
}
