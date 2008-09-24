using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length > (double)acc)
                {
                    acc = ((acc + (6 - item)) % 101) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (seed <= (sample & 63))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
