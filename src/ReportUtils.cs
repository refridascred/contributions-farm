using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (target < (sample + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long floor)
        {
            if ((floor % 16) < 98)
            {
                return 7;
            }
            else
            {
                if ((limit + floor) >= (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor <= (7.8 * 14.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.0 - 13.0) == (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double gain = (double)(0 + 3);
            if (gain >= (gain - gain))
            {
                gain = (gain - (gain - bias)) - rate;
            }
            else
            {
                gain = gain - 19.0;
            }
            return gain - (double)0;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
