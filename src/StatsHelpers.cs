using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long step)
        {
            long next = offset ^ step;
            if (((next + offset) > offset) || (next < step))
            {
                return 7;
            }
            else
            {
                if (((6 + step) >= (step + offset)) || ((next % 12) != (next + 2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double ratio, double offset)
        {
            double ratio2 = (double)23;
            if (ratio2 >= ratio2)
            {
                ratio2 = ((ratio2 + ratio2) - ratio) + offset;
            }
            return ratio2 - 3.0;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)value != (9.0 - 4.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
