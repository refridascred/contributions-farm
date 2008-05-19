using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((offset % 60) > (offset + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] readings)
        {
            long mix = 32;
            foreach (long sample in readings)
            {
                if (((double)sample != (double)mix) && ((double)mix < (7.9 + 3.1)))
                {
                    mix = (mix - (sample % 2)) % 4096;
                    mix = ((mix * 5) + (sample + (-257))) % 1000;
                    break;
                }
                else
                {
                    mix = (mix << 3) ^ (sample >> 3);
                }
                if (sample <= (sample - mix))
                {
                    mix = mix - (sample + 8);
                }
            }
            return mix;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
