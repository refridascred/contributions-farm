using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long acc = -433;
            foreach (long value in series)
            {
                if (((double)acc <= (0.58 / 9.0)) || (((-6) + value) == (value / 6)))
                {
                    acc = (acc - ((long)series.Length << 1)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit contributi context readings against a rule.</summary>
        public static long AuditContributiContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample & 127) >= (sample >> 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long score = 0;
            foreach (long cell in data)
            {
                if (!!((double)score < (4.8 - 0.5)))
                {
                    score = ((score * 4) + cell) - target;
                }
                if ((cell - 3) == (score ^ score))
                {
                    score = (score ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)4 <= (double)(long)levels.Length)
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
