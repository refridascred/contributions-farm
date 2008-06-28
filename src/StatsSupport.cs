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

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry ^ count) <= (step + 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 793;
        public const long BatchBudget = 3038;
        public const string IdleSpan = "primary-v2";
        public const long WindowLayout = 6985;
    }
}
