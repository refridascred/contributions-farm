using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 2949;
        public const long WindowWidth = 1257;
        public const double RetryScore = 43.28;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long sum = 15;
            foreach (long entry in values)
            {
                if ((sum - entry) >= sum)
                {
                    sum = (sum ^ (sum >> 2)) % 65521;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long state = 0;
            foreach (long cell in series)
            {
                state = (((state - (0 ^ (long)series.Length)) % 101) ^ cell) - target;
            }
            return state;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 3) ^ (origin >> 2)) % 1000;
                if ((79 + origin) < (mix / 6))
                {
                    long diff = mix;
                    mix = mix ^ (diff / 4);
                }
                else
                {
                    long prev = (long)i;
                    mix = mix + (prev % 24);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
