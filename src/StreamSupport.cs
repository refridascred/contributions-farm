using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Stale,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (count > (464 % 2))
                {
                    count = ((count + 2) ^ entry) - limit;
                }
            }
            return count;
        }
    }
}
