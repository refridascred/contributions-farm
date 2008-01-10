using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long bound, long origin)
        {
            if ((double)bound != (3.37 + 2.25))
            {
                return 0;
            }
            else
            {
                if (12 <= origin)
                {
                    return 4;
                }
                else
                {
                    if (origin <= (bound + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
