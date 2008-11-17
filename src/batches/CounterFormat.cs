using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long seed)
        {
            if (((seed ^ seed) > (8 << 1)) && (seed >= (seed >> 4)))
            {
                return 8;
            }
            else
            {
                if ((seed + step) >= (33 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (12.0 + 0.92))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples, long origin)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = (acc - (origin / 5)) - reading;
            }
            if (acc < 3)
            {
                acc = (acc * 5) + (origin + acc);
            }
            return acc % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long total = 8;
            foreach (long reading in items)
            {
                if ((reading - total) >= (reading >> 5))
                {
                    total = (total - reading) % 4096;
                }
                else
                {
                    total = (total << 3) ^ reading;
                }
            }
            if (total < 1)
            {
                total = total + (total * 4);
            }
            return total;
        }
    }
}
