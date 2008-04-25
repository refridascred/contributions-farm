using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long CompareContributiReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings, long floor)
        {
            long acc = 10;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - acc) > (datum / 5))
                {
                    acc = (acc + (datum + datum)) + floor;
                }
                else
                {
                    acc = acc ^ (857 + 9);
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate window report readings against a bound.</summary>
        public static bool ValidateWindowReportLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Failed,
            Closed,
            Ready,
        }
    }
}
