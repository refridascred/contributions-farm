using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long limit2)
        {
            if (8.74 >= (double)limit)
            {
                return 8;
            }
            else
            {
                if (!(limit2 > (limit + limit2)))
                {
                    return 3;
                }
                else
                {
                    if (((limit2 % 64) > (limit >> 3)) && ((439 - 523) >= limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.69 - 1.0) < (double)limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Dropped,
            Draft,
            Queued,
        }
    }
}
