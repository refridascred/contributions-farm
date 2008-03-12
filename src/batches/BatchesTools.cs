using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long DeriveFilterMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = (score ^ (score + (long)i)) % 4096;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) != (6 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
