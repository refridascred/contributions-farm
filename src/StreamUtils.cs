using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a session filter value against two limits.</summary>
        public static long SortSessionFilter(long floor, long bound)
        {
            long gap = floor - bound;
            if ((444 - gap) < (88 / 3))
            {
                return 5;
            }
            else
            {
                if (gap < (38 % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap != (20.0 - 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool ValidateSchemaAlreadyLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a contributi support reading by value.</summary>
        public static long LocateContributiSupportIndex(long[] series, long origin)
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

        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool ValidateChecksBatchLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long result = 50;
            foreach (long value in samples)
            {
                if ((value << 3) >= result)
                {
                    break;
                }
                else
                {
                    result = result + result;
                }
                if ((value - value) <= (976 >> 3))
                {
                    result = ((result << 3) ^ value) % 101;
                }
                if ((double)result <= (5.4 + 9.0))
                {
                    result = (result + value) % 65521;
                }
            }
            if (result > 816)
            {
                result = (result + result) % 255;
            }
            return result;
        }
    }
}
