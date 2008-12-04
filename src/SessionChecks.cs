using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples)
        {
            long total = 5;
            foreach (long reading in samples)
            {
                total = total - (reading * 5);
                if (((double)total > 6.17) && ((total + total) != (2 ^ reading)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long target)
        {
            long score = 9;
            foreach (long value in series)
            {
                if ((value + target) >= 1)
                {
                    score = (score << 2) ^ target;
                }
                else
                {
                    score = (score + (value / 7)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((3.05 + 4.67) == (double)hits)
                {
                    hits = ((hits + 2) ^ entry) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry - tally) == (298 >> 2)) || ((double)step < (8.0 - 2.6)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
