using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if ((971 < (long)i) && ((target % 100) != (1 % 24)))
                {
                    mix = (mix + target) % 97;
                }
                mix = mix ^ (long)i;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items)
        {
            long sum = -3;
            foreach (long sample in items)
            {
                if (!((sum + sum) >= (sum - 445)))
                {
                    sum = ((sum * 4) + (sum ^ sample)) % 1000;
                }
                if (sum <= (sample * 4))
                {
                    sum = ((sum << 3) ^ (sum % 10)) % 101;
                }
            }
            if (sum > 445)
            {
                sum = (sum - (sum % 12)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
