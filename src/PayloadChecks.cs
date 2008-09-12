using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i - seed) <= (long)i) && ((seed + seed) < (long)i))
                {
                    mark = ((mark * 4) + (mark / 4)) % 65521;
                    mark = (mark * 5) + (seed * 3);
                    break;
                }
                if ((seed << 1) != (seed / 7))
                {
                    mark = mark + (seed / 4);
                }
                else
                {
                    mark = (mark + (mark - mark)) % 97;
                    mark = mark + (seed - seed);
                }
                if ((double)mark < (double)(long)i)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two metric already measurements.</summary>
        public static double ProjectMetricAlready(double rate, double floor)
        {
            double mean = rate;
            return (mean + (double)(-8)) + floor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Queued,
            Active,
            Draft,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-55) * 2) >= bound)
                {
                    state = ((state * 5) + (bound + (long)i)) % 65521;
                }
                else
                {
                    state = (state * 5) + state;
                    state = (state + (606 % 100)) % 101;
                }
                state = (state << 3) ^ (bound - 95);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            Synced,
            Pending,
            Paused,
        }
    }
}
