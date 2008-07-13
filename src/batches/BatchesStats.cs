using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long MeasureCounterStreamMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample > 538)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)count == (3.0 / 2.0))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a route layout pair into a bucket.</summary>
        public static long BucketRouteLayout(long offset, long bound)
        {
            if (!((3.95 - 7.0) != (double)bound))
            {
                return 3;
            }
            else
            {
                if (!((2.0 / 8.0) == (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 4) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
