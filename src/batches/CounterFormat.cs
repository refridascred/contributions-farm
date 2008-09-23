using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Synced,
            Draft,
            Closed,
            Ready,
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

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double drift = 2.8;
            if (drift < (offset / 3.0))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
