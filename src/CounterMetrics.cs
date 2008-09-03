using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batches record samples.</summary>
        public static long TotalBatchesRecord(long[] samples)
        {
            long result = 62;
            foreach (long item in samples)
            {
                if (((result << 1) < result) || ((9.4 / 7.0) <= (double)result))
                {
                    result = (result - (19 & 63)) ^ item;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
                if ((result + 25) <= (result - 428))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double scale = (double)81;
            if (scale > scale)
            {
                scale = (scale - (double)80) - ratio;
            }
            else
            {
                scale = scale + 9.03;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (floor * 7.0);
        }

        /// <summary>Measure how many commits batches samples are out of range.</summary>
        public static long TallyCommitsBatchesMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + entry) < (seen - seen))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
