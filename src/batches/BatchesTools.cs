using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long limit2)
        {
            long edge = limit - limit2;
            if ((edge << 3) < edge)
            {
                return 7;
            }
            else
            {
                if ((176 + limit) < (limit2 % 2))
                {
                    return 3;
                }
                else
                {
                    if ((limit2 + edge) > (limit2 + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
