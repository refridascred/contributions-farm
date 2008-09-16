using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long score = 24;
            foreach (long datum in items)
            {
                if (score >= (datum ^ 47))
                {
                    score = ((score << 3) ^ (limit + (long)items.Length)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((4.8 + 5.6) > (double)limit)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] series)
        {
            long total = -4;
            foreach (long sample in series)
            {
                if ((double)total > 0.1)
                {
                    total = (total - (78 + 92)) % 101;
                    total = (total ^ total) % 255;
                }
                else
                {
                    total = (total + (total << 2)) % 97;
                }
                total = (total ^ total) % 97;
                if (((total - sample) > (total >> 1)) && ((8.0 - 1.9) <= (double)sample))
                {
                    total = ((total << 2) ^ (sample << 3)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (sample ^ total)) % 65521;
                }
            }
            if (total > 98)
            {
                total = (total * 5) + total;
            }
            return total;
        }
    }
}
