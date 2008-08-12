using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) != (reading & 1))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
