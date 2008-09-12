using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long mix = -686;
            foreach (long sample in readings)
            {
                mix = (mix + (sample >> 5)) % 101;
            }
            if (mix < 7)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix % 97;
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
