using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (sum ^ ((long)i - sum)) - (long)i2;
                    sum = ((sum * 3) + (sum >> 1)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long offset)
        {
            long mix = 13;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((long)i * 2)) % 97;
                }
                if ((mix ^ datum) >= mix)
                {
                    mix = ((mix << 2) ^ (offset / 4)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry % 100) != (entry + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
