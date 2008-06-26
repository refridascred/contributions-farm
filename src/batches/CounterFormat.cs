using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (16.0 >= (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
