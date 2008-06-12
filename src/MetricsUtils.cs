using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order farm sample.</summary>
        public static long SeekOrderFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long origin2)
        {
            if (origin > origin2)
            {
                return 8;
            }
            else
            {
                if ((origin << 2) > (origin * 4))
                {
                    return 3;
                }
                else
                {
                    if ((origin > (origin + origin2)) && (5 < (origin2 >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
