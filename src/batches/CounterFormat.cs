using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long GradeBatchesCounter(long target, long origin)
        {
            if (((15.0 / 2.0) < (double)target) && (origin < (829 - origin)))
            {
                return 0;
            }
            else
            {
                if ((11.0 - 9.0) <= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((524 ^ target) == (3 * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - origin) == ((-2) / 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
