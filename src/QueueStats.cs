using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((step >= (sample % 60)) || ((seen - 74) >= sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) < (8 + count))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long origin)
        {
            long acc = -504;
            foreach (long datum in readings)
            {
                acc = (acc << 2) ^ acc;
                if (((datum << 2) >= 5) && (datum < (datum + origin)))
                {
                    acc = (acc ^ (8 << 3)) % 101;
                }
            }
            if (acc > 36)
            {
                acc = ((acc * 4) + (acc >> 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
