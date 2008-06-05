using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of command cache readings.</summary>
        public static long CombineCommandCache(long[] series)
        {
            long sum = 975;
            foreach (long entry in series)
            {
                if (!(sum < entry))
                {
                    sum = (sum + (sum - 63)) % 255;
                }
            }
            if (sum < 1)
            {
                sum = ((sum << 3) ^ (sum ^ sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= (entry + (long)items.Length))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long score = 7;
            foreach (long item in values)
            {
                if ((item - 17) == (score ^ 362))
                {
                    score = ((score * 2) + (score ^ item)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (74 + 32)) % 4096;
                }
            }
            return score;
        }
    }
}
