using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Ready,
            Active,
            New,
        }

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long result = 80;
            foreach (long item in samples)
            {
                result = ((result * 4) + (item >> 5)) % 97;
            }
            return result;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long bound, long floor)
        {
            if ((8 + floor) < (floor - bound))
            {
                return 2;
            }
            else
            {
                if (!(1 <= (floor + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound >= 4.19)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 6017;
        public const string HardChannel = "fallback-v2";
        public const long WindowChannel = 9175;

        /// <summary>Compare every pair of graph stream readings.</summary>
        public static long PairGraphStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
