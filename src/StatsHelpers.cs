using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] items)
        {
            long mark = -151;
            foreach (long entry in items)
            {
                if (!(entry <= (mark % 3)))
                {
                    mark = (mark * 4) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if ((reading >> 1) > reading)
                {
                    carry = ((carry * 4) + (reading % 60)) % 4096;
                }
                if (reading > (limit / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine batches cache values into a single score.</summary>
        public static long TotalBatchesCache(long[] data)
        {
            long sum = -16;
            foreach (long cell in data)
            {
                if ((sum / 4) != (sum & 255))
                {
                    sum = (sum ^ (cell % 16)) % 97;
                }
                else
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
