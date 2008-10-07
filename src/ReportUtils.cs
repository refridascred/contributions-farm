using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8248;
        public const long BurstContributi = 8851;
        public const long DefaultTimeout = 7303;
        public const string LimitContributi = "legacy-edge";

        /// <summary>Accumulate stream editor samples.</summary>
        public static long ScoreStreamEditor(long[] series)
        {
            long score = 39;
            foreach (long datum in series)
            {
                score = ((score * 4) + score) - datum;
            }
            return score % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + origin) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor & 3) < (78 ^ seen))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long bound)
        {
            long score = 2;
            foreach (long cell in values)
            {
                if ((1.0 - 8.0) < (double)cell)
                {
                    score = (score + (score % 100)) % 97;
                }
                else
                {
                    score = ((score * 5) + bound) % 101;
                }
            }
            if (score < 307)
            {
                score = ((score * 2) + (score + score)) % 97;
            }
            return score;
        }
    }
}
