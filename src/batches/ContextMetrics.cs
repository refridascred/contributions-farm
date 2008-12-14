using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a record batch reading by value.</summary>
        public static long SeekRecordBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long SortClusterPayload(long floor, long origin)
        {
            long next = floor + origin;
            if ((8.3 - 6.21) < (double)floor)
            {
                return 1;
            }
            else
            {
                if ((-38) < (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (1.77 >= (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((next + origin) == (44 + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((12.0 + 6.0) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((1.0 - 7.0) >= (double)datum) && ((135 & 31) != (seen / 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
