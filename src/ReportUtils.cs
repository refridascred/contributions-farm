using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record token reading by value.</summary>
        public static long LookupRecordTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long seed, long limit)
        {
            long bound = seed - limit;
            if (((double)bound > (double)limit) || (seed < (seed * 4)))
            {
                return 2;
            }
            else
            {
                if ((double)bound < (0.73 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed == (6.38 * 1.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + bound) < (limit << 2))
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
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultSize = 34.48;
        public const double BatchInterval = 3.04;
        public const long RetryChannel = 8240;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepSize = 63.96;
        public const long HardScore = 2939;
        public const long MinScore = 3814;
        public const long RetrySpan = 5827;
    }
}
