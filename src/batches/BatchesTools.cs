using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if (1.93 >= (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset < (offset * 4)) || ((limit - 73) < offset))
                {
                    return 1;
                }
                else
                {
                    if ((limit << 3) != (limit + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 / 5.0) != (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
