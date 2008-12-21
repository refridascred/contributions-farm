using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
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
