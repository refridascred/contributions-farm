using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Paused,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((18.0 < (double)hits) && ((19.0 / 7.0) > (double)origin))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings, long seed)
        {
            long sum = 761;
            foreach (long value in readings)
            {
                if ((value ^ seed) <= (seed * 3))
                {
                    continue;
                }
                sum = (sum + (value * 3)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
