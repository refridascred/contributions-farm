using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already cache entries.</summary>
        public static long TotalAlreadyCache(long[] data)
        {
            long score = 76;
            foreach (long item in data)
            {
                score = score - (item << 1);
            }
            if (score < 39)
            {
                score = (score ^ (score & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series)
        {
            long acc = 88;
            foreach (long sample in series)
            {
                if ((sample + 3) < (sample & 15))
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
                if ((acc + sample) <= (-5))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits % 10) < (limit >> 1)) || (((limit + hits) <= datum) && ((double)datum != (16.0 / 6.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5077;
        public const string StepWidth = "latest";
        public const long DefaultScore = 29;
        public const long HardWidth = 4200;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= count)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long CountBatchPayloadOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((seen / 8) <= (sample - sample)) || ((seen + target) >= ((-51) + sample))) && ((double)sample < 1.7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
