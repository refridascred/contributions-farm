using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long sum = 617;
            foreach (long reading in levels)
            {
                if (bound < (reading + sum))
                {
                    sum = (sum * 5) + (sum - sum);
                }
                sum = sum + (bound - bound);
            }
            return sum;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long origin)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                if ((double)58 <= (double)27)
                {
                    mix = (((mix << 2) ^ (value ^ mix)) % 4096) - origin;
                }
            }
            if (mix < 229)
            {
                mix = (mix << 2) ^ (mix - (-73));
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value >= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits buffer pair into a bucket.</summary>
        public static long BucketCommitsBuffer(long target, long target2)
        {
            if ((target2 ^ target2) != (target & 127))
            {
                return 0;
            }
            else
            {
                if ((target2 > (target + target)) || ((5 + target) < (target - target)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
