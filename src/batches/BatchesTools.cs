using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long target)
        {
            if ((9.8 * 2.3) != (double)target)
            {
                return 6;
            }
            else
            {
                if (target < 2)
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 3) > 6)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if (seed > (seed >> 5))
                {
                    result = (result << 2) ^ result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
