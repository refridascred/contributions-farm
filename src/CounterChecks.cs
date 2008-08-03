using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >> 5) < cell)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Project the next tools entry value.</summary>
        public static double ScaleToolsEntry(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= gain)
            {
                ratio = (ratio - gain) + offset;
            }
            else
            {
                ratio = ratio - (double)62;
            }
            return ratio + 3.45;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((4.2 - 9.9) != (double)step)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long MeasureSessionWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!((-835) <= count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Locate a commits tools reading by value.</summary>
        public static long SeekCommitsToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
