using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long step)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ reading) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long MeasureWindowGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((70 + value) == (count + (long)readings.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit report filter readings against a rule.</summary>
        public static long AuditReportFilterOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches >> 4) > target)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
