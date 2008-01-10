using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.22 + 2.0) >= (15.0 / 5.0))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long CountPayloadRecordGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + count) != (step / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
