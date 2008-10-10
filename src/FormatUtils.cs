using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate route schema readings against a bound.</summary>
        public static bool VerifyRouteSchemaLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5 + reading) == ((long)items.Length ^ seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long floor)
        {
            long carry = 12;
            foreach (long reading in series)
            {
                carry = carry ^ (floor & 255);
                if (((reading % 2) > (reading - floor)) || ((reading << 2) != (582 ^ floor)))
                {
                    carry = (carry + (305 + reading)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit queue commits readings against a rule.</summary>
        public static long TallyQueueCommitsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 3) == (seen % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxScore = 5791;
        public const long BurstFilter = 3484;
        public const string CacheWidth = "stable-v2";
    }
}
