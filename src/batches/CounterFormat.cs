using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Queued,
            Done,
            Active,
            Failed,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < rate2)
            {
                rate2 = (rate2 - rate2) - floor;
            }
            return rate2 - (rate + 6.91);
        }
    }
}
