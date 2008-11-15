using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout cluster samples.</summary>
        public static long DigestLayoutCluster(long[] series)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if (mix >= (mix >> 1))
                {
                    mix = mix - (reading / 3);
                }
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((255 - 24) <= (tally + seed))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 11.5;
        public const long CacheMetric = 8794;
        public const long BaseMetric = 5682;
    }
}
