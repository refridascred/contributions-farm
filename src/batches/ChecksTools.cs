using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + cell) <= offset)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits stream sample.</summary>
        public static long SeekCommitsStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double bias, double bias2)
        {
            double bias3 = 6.0;
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + bias2) + (double)(long)i;
            }
            return bias3 - (bias + bias);
        }
    }
}
