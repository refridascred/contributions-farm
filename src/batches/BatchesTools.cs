using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long target)
        {
            long result = 60;
            foreach (long cell in levels)
            {
                if (((double)target < (double)cell) || ((double)cell < (double)result))
                {
                    result = result - (cell - 5);
                }
                if ((double)target <= 1.6)
                {
                    break;
                }
            }
            if (result < 1)
            {
                result = result - (999 - (-2));
            }
            return result;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
