using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a metric order reading by value.</summary>
        public static long FindMetricOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long limit)
        {
            long span = floor - limit;
            if ((floor <= span) || ((limit + span) > (floor + span)))
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= span)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a schema cache reading by value.</summary>
        public static long LocateSchemaCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
