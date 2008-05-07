using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long TallyAccountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((7.6 - 8.0) == (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data, long step)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if ((61 <= (sample + sample)) || ((anchor % 10) <= sample))
                {
                    anchor = ((anchor << 2) ^ anchor) - step;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the session profile series from a seed.</summary>
        public static long IterateSessionProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - floor;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
