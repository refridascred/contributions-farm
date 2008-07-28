using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((6 + item) <= (item & 255)) || ((matches << 3) >= target)) && ((target << 1) >= target))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data, long limit)
        {
            long sum = 2;
            foreach (long value in data)
            {
                if (sum <= (limit - limit))
                {
                    sum = (sum - (sum + limit)) ^ value;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum << 3)) % 1000;
                }
            }
            if (sum < 983)
            {
                sum = ((sum * 2) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long target)
        {
            if ((origin & 3) >= (origin - origin))
            {
                return 7;
            }
            else
            {
                if (target < ((-232) << 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] series, long limit)
        {
            long mark = 387;
            foreach (long sample in series)
            {
                if (!(sample < (mark - sample)))
                {
                    mark = (((mark * 4) + (mark + mark)) % 1000) + limit;
                }
                else
                {
                    mark = ((mark << 2) ^ 6) % 255;
                }
            }
            return mark;
        }
    }
}
