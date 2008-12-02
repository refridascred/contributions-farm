using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen ^ seen) <= (7 ^ 733))
                {
                    seen = ((seen + 2) ^ entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command schema readings against a bound.</summary>
        public static bool CheckCommandSchemaBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
