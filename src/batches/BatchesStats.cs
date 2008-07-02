using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Draft,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
