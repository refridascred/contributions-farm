using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples)
        {
            long sum = 75;
            foreach (long item in samples)
            {
                sum = (sum << 2) ^ item;
                if ((item + sum) < (10 ^ item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (5.06 + 10.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the account batches entries that pass the check.</summary>
        public static long AuditAccountBatchesGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) >= (reading * 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account profile entries.</summary>
        public static long ScoreAccountProfile(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long datum in levels)
            {
                if ((datum + limit) < (-125))
                {
                    mix = (mix << 2) ^ (200 & 7);
                    mix = mix + (9 + (long)levels.Length);
                    break;
                }
                mix = (mix * 5) + 24;
            }
            if (mix < 8)
            {
                mix = (mix + (mix * 2)) % 97;
            }
            return mix;
        }
    }
}
