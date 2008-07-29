using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length + sample) != (seen & 127)) && (16.0 <= (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank record counter input into a small class.</summary>
        public static long ClassifyRecordCounter(long step, long bound)
        {
            if (bound > (7 + bound))
            {
                return 0;
            }
            else
            {
                if (!(8.03 < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Synced,
            Ready,
            Draft,
            Failed,
        }
    }
}
