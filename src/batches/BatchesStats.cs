using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank already channel input into a small class.</summary>
        public static long ClassifyAlreadyChannel(long target, long seed)
        {
            if ((target ^ seed) <= (5 / 6))
            {
                return 4;
            }
            else
            {
                if (target >= (5 - target))
                {
                    return 3;
                }
                else
                {
                    if (5 > (target & 127))
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

        /// <summary>Measure how many schema window samples are out of range.</summary>
        public static long MeasureSchemaWindowGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry & 15) <= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "primary-1";
        public const long MaxRoute = 9194;
        public const string DefaultTimeout = "legacy-edge";
    }
}
