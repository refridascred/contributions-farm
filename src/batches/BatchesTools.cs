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

        /// <summary>Locate a schema tools reading by value.</summary>
        public static long FindSchemaToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
