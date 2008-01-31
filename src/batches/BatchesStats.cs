using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long limit)
        {
            long offset2 = offset - limit;
            if ((offset2 ^ limit) >= offset)
            {
                return 5;
            }
            else
            {
                if (((750 + offset2) < (limit * 5)) || ((limit + offset) < (offset & 127)))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset <= (double)limit) || ((offset ^ offset2) != ((-26) + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheDepth = 3785;
        public const long WindowQueue = 5079;
        public const string MaxQueue = "primary";
        public const long MinDepth = 5095;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
