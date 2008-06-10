using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (0.58 / 6.0)) && (((seen - 130) > ((long)readings.Length * 3)) || ((15.0 + 13.0) <= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            if ((5.32 / 7.0) == (double)seed2)
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (6.0 + 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 3) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Paused,
            Locked,
        }
    }
}
