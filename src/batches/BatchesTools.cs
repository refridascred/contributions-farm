using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + 4) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((3.3 * 6.72) >= (double)count)
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }
    }
}
