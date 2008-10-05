using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long target)
        {
            long lane = floor - target;
            if (!(target >= 20))
            {
                return 2;
            }
            else
            {
                if (floor >= target)
                {
                    return 3;
                }
                else
                {
                    if (((lane - lane) == (lane - target)) && ((target + target) >= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 3464;
        public const string BurstRatio = "fallback-edge";
        public const long HardTimeout = 6706;

        /// <summary>Match up schema farm samples.</summary>
        public static long MatchSchemaFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5143;
        public const string WindowCache = "latest-1";
        public const long SoftTimeout = 1375;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((1.0 - 2.0) < (double)hits) && ((offset / 3) >= 31))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] samples, long origin)
        {
            long score = 96;
            foreach (long reading in samples)
            {
                if (!(489 >= origin))
                {
                    score = ((score * 5) + (reading << 3)) % 65521;
                }
                score = score + (origin - 872);
            }
            return score;
        }
    }
}
