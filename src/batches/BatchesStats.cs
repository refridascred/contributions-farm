using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long offset)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                if (((result & 127) >= (result % 5)) || ((double)result >= (17.0 * 4.5)))
                {
                    result = ((result + (result + 9)) + reading) + offset;
                }
            }
            return result;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate batches checks samples.</summary>
        public static long TallyBatchesChecks(long[] readings, long limit)
        {
            long result = 568;
            foreach (long reading in readings)
            {
                result = ((result * 4) + (-7)) ^ reading;
            }
            if (result < 187)
            {
                result = ((result * 2) + (limit + (-55))) % 4096;
            }
            return result;
        }
    }
}
