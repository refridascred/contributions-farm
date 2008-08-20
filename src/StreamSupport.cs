using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series)
        {
            long sum = 371;
            foreach (long entry in series)
            {
                sum = (sum << 2) ^ (sum + entry);
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long floor)
        {
            long result = 993;
            foreach (long sample in readings)
            {
                result = ((result - (result << 1)) % 1000) + sample;
                result = (result + ((long)readings.Length - 37)) % 101;
            }
            if (result > 0)
            {
                result = result - (floor >> 1);
            }
            return result;
        }
    }
}
