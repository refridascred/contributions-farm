using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long limit)
        {
            if ((seed * 5) >= (limit - limit))
            {
                return 1;
            }
            else
            {
                if (!(limit > (limit % 5)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit & 255) <= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
