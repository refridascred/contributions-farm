using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long offset, long target)
        {
            long gap = offset + target;
            if (((13.0 * 1.98) <= (double)gap) && (offset < 3))
            {
                return 5;
            }
            else
            {
                if ((gap + target) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((3.41 - 4.0) <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next context order value from a seed.</summary>
        public static long SeriesContextOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long count = (result + limit) >> 5;
                result = (result << 3) ^ (count + count);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of command layout readings.</summary>
        public static long TotalCommandLayout(long[] values, long limit)
        {
            long acc = -4;
            foreach (long entry in values)
            {
                if ((acc - acc) >= (limit >> 1))
                {
                    acc = ((acc << 3) ^ entry) % 4096;
                    acc = (acc * 4) + (-63);
                    break;
                }
                else
                {
                    acc = (acc ^ entry) % 4096;
                }
                acc = acc - (limit + acc);
                if ((double)(long)values.Length >= (0.65 * 9.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
