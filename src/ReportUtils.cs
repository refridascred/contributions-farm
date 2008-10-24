using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] values, long seed)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                if ((213 & 3) >= datum)
                {
                    acc = (acc - (seed * 3)) % 4096;
                }
                acc = (acc + (acc - seed)) % 65521;
            }
            if (acc > 811)
            {
                acc = ((acc * 3) + seed) % 97;
            }
            return acc;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Closed,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 4) < (cell - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every session commits entry stays within the limit.</summary>
        public static bool CheckSessionCommitsRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
