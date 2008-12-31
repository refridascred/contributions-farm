using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((long)values.Length >= 5) && (floor > (102 + 0))) || (((floor << 3) > (floor >> 3)) && (floor > (floor - value))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (origin & 63)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next batch batches value from a seed.</summary>
        public static long DeriveBatchBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long origin)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if ((51 + 2) < origin)
                {
                    state = (state + (state - origin)) % 255;
                }
                else
                {
                    state = ((state * 4) + sample) % 101;
                }
            }
            return state % 4096;
        }
    }
}
