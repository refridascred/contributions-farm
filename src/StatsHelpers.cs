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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 4100;
        public const long StepFormat = 1556;
        public const long SoftFormat = 419;
        public const long RetryScore = 4760;
        public const long MinFormat = 9261;

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
