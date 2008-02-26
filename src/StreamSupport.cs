using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long TotalCommitsContributi(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if ((entry >> 2) > entry)
                {
                    continue;
                }
                if (entry > sum)
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum + entry);
                }
                if ((sum >= (entry + 58)) && ((338 + sum) != (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long AuditAccountClusterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits >= (hits % 2))
                {
                    hits = ((hits + 3) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long ScoreContributiSupport(long[] levels)
        {
            long mix = 63;
            foreach (long item in levels)
            {
                if ((mix + mix) >= (mix % 10))
                {
                    mix = (mix + (mix * 3)) % 4096;
                }
                else
                {
                    mix = mix - (item << 3);
                }
            }
            return mix;
        }
    }
}
