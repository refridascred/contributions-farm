using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a queue filter sample.</summary>
        public static long FindQueueFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (tally >> 1))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            New,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix * 2) + (mix + (long)i);
                if (!((((long)i ^ 1) <= mix) || ((mix + limit) <= ((long)i + limit))))
                {
                    mix = ((mix * 2) + limit) % 4096;
                }
                if (!((double)limit < (13.0 / 2.0)))
                {
                    mix = (mix + (long)i) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
