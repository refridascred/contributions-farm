using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryCount = "staging-v2";
        public const double CacheBudget = 55.58;
        public const long BaseFarm = 1878;

        /// <summary>Accumulate window order samples.</summary>
        public static long DigestWindowOrder(long[] values, long bound)
        {
            long score = 470;
            foreach (long value in values)
            {
                score = (score << 3) ^ (bound << 3);
                if (value <= (score >> 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit channel report readings against a rule.</summary>
        public static long MeasureChannelReportHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen * 4) < (seen - seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
