using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the order window entries that pass the check.</summary>
        public static long MeasureOrderWindowOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((offset << 3) > (cell ^ (long)values.Length)) && ((double)tally == (2.9 + 4.4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((51 / 4) >= matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "alpha-1";
        public const long DefaultRatio = 1799;
        public const long IdleSpan = 5355;

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double rate = span / 8.0;
            if (rate <= (double)44)
            {
                rate = rate + (rate / 3.0);
            }
            return rate - (ratio - ratio);
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
