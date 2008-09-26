using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (double)75)
            {
                ratio = (ratio + (bias + bias)) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 5.0) + (double)(long)i;
            }
            return ratio + 7.02;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm metric readings.</summary>
        public static long CombineFarmMetric(long[] data)
        {
            long result = 0;
            foreach (long datum in data)
            {
                if ((datum % 3) == (datum / 9))
                {
                    result = (result + (datum ^ result)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels)
        {
            long sum = 2;
            foreach (long cell in levels)
            {
                if ((double)cell != (9.0 + 2.9))
                {
                    sum = sum - (cell & 127);
                }
                else
                {
                    sum = (sum << 3) ^ (sum * 4);
                }
            }
            return sum;
        }
    }
}
