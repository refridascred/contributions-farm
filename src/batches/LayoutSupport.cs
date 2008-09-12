using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry < seed) && ((seed << 2) > (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] series, long limit)
        {
            long score = 271;
            foreach (long item in series)
            {
                if (!((item * 5) > 10))
                {
                    score = (score - (limit << 2)) % 97;
                    score = (score ^ (item & 7)) % 255;
                }
                score = (score - limit) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 5) < (338 + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long sum = 808;
            foreach (long value in series)
            {
                sum = (sum + 591) % 1000;
                if ((double)value >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 128)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
