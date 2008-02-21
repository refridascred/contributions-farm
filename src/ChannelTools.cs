using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples, long target)
        {
            long acc = 611;
            foreach (long value in samples)
            {
                if ((34 >= target) && (7.7 < (double)target))
                {
                    acc = ((acc << 2) ^ acc) ^ value;
                }
            }
            if (acc < 80)
            {
                acc = (acc * 5) + target;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 9) == (seen - 52))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length >> 4) >= (sample + hits))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
