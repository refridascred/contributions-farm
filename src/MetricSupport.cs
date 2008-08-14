using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many contributi command samples are out of range.</summary>
        public static long MeasureContributiCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(hits > value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - tally) >= (tally << 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
