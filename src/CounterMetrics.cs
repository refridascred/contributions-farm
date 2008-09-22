using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Failed,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) > (6 % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series, long bound)
        {
            long result = 5;
            foreach (long sample in series)
            {
                if ((result + result) > (result ^ 3))
                {
                    result = (result ^ bound) - sample;
                }
            }
            if (result > (-4))
            {
                result = (result * 5) + (result * 5);
            }
            return result;
        }
    }
}
