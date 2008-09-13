using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long limit, long target)
        {
            if ((target / 6) < limit)
            {
                return 6;
            }
            else
            {
                if ((target / 6) < target)
                {
                    return 2;
                }
                else
                {
                    if ((6 % 60) < target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target ^ limit) <= (0 + target)) && ((target + 59) != (limit << 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
