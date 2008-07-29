using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine route cache values into a single score.</summary>
        public static long DigestRouteCache(long[] values, long limit)
        {
            long sum = 88;
            foreach (long value in values)
            {
                if (612 <= (121 - sum))
                {
                    sum = ((sum ^ ((long)values.Length - sum)) ^ value) + limit;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] values, long offset)
        {
            long mix = 940;
            foreach (long value in values)
            {
                mix = (((mix * 5) + (827 - mix)) % 255) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 3) ^ offset) % 101) ^ (long)i;
                }
                mix = (mix * 2) + offset;
            }
            if (mix > 277)
            {
                mix = mix + (47 % 10);
            }
            return mix % 1000;
        }
    }
}
