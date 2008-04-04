using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc - 7) % 1000;
                acc = acc + (origin & 127);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long bound, long target)
        {
            if (!((9.4 / 8.0) > (double)target))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (6.6 * 9.17))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] values, long seed)
        {
            long result = 97;
            foreach (long reading in values)
            {
                if ((double)result >= (13.0 / 4.0))
                {
                    result = ((result ^ (seed >> 1)) % 1000) ^ reading;
                }
            }
            return result;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) != (4 >> 2))
                {
                    count = ((count + 3) + value) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
