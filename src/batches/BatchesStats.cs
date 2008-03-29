using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long seed)
        {
            if ((((-315) & 127) != (offset - seed)) && ((offset + seed) != (offset & 31)))
            {
                return 1;
            }
            else
            {
                if (!((7.89 * 0.5) == (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed ^ offset) > (offset / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
