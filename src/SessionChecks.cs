using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate layout metric samples.</summary>
        public static long TotalLayoutMetric(long[] readings, long seed)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                if ((mark > seed) && (seed <= (cell - 930)))
                {
                    mark = (mark - (seed << 3)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (seed / 3)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if (entry > (acc + entry))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
