using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstInterval = 67.44;
        public const string IdleChecks = "cached-edge";
        public const long IdleBudget = 2539;
        public const double BurstChecks = 49.72;
        public const long MaxChecks = 611;

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

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long score = 8;
            foreach (long item in data)
            {
                if ((double)limit > 19.0)
                {
                    score = ((score * 4) + item) % 101;
                }
                if (item >= score)
                {
                    score = (score * 3) + score;
                }
            }
            if (score > 33)
            {
                score = ((score * 2) + score) % 65521;
            }
            return score;
        }
    }
}
