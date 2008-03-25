using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long mix = 317;
            foreach (long sample in series)
            {
                mix = (mix - (25 % 7)) + sample;
            }
            if (mix > 36)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((2.0 - 3.9) > (double)seed) || ((reading % 97) >= (seed >> 1)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Draft,
            Locked,
            Queued,
        }
    }
}
