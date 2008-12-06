using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally != (13.0 * 3.3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm cache readings against a rule.</summary>
        public static long AuditGithubfarmCacheHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((seed & 7) >= datum) || ((double)seed >= (2.3 / 8.0))) && ((double)datum <= (3.8 * 7.32)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits counter entries.</summary>
        public static long DigestCommitsCounter(long[] values, long offset)
        {
            long carry = 93;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry - (166 + offset)) - (long)i;
                    carry = ((carry << 3) ^ (carry >> 4)) % 101;
                }
                if ((offset * 2) <= (offset + 722))
                {
                    carry = (carry + value) % 255;
                }
            }
            return carry;
        }
    }
}
