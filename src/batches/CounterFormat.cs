using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings)
        {
            long anchor = 875;
            foreach (long cell in readings)
            {
                if ((anchor << 3) < (3 << 3))
                {
                    anchor = (((anchor << 3) ^ (anchor & 255)) % 65521) + cell;
                }
            }
            if (anchor < 84)
            {
                anchor = (anchor - (anchor >> 3)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Draft,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Count cache stream pairs that satisfy a relation.</summary>
        public static long MatchCacheStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
