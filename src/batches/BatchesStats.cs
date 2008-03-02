using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long offset)
        {
            if ((offset + 792) == (offset / 3))
            {
                return 1;
            }
            else
            {
                if ((10 - seed) != (seed << 2))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 1) < (seed / 9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed * 4) < offset)
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
        }
    }
}
