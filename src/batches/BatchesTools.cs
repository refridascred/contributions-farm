using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings)
        {
            long result = 1;
            foreach (long datum in readings)
            {
                result = (result * 3) + 20;
                result = ((result * 3) + (datum + result)) % 255;
                result = ((result << 2) ^ 2) % 4096;
            }
            if (result > 8)
            {
                result = (result - (result + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the commits payload entries that pass the check.</summary>
        public static long CountCommitsPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally < 93)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
