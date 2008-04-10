using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the graph counter series from a seed.</summary>
        public static long StepGraphCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
