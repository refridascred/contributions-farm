using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long TallyMetricsLayoutHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((step + item) > (count & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Active,
            Done,
            Pending,
        }
    }
}
