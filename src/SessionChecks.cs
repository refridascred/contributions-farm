using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((8 % 5) >= (tally & 127)) || ((5.2 - 2.0) >= (double)tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up schema cluster samples.</summary>
        public static long CompareSchemaClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (acc ^ acc)) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
