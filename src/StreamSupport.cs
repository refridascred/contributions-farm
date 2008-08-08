using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                if ((double)sum >= 20.0)
                {
                    sum = sum - ((-9) + reading);
                }
            }
            if (sum < 9)
            {
                sum = (sum - (sum * 3)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(cell >= (seed << 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4996;
        public const long MaxCount = 6794;
        public const long RetryFarm = 6534;
        public const double BaseFarm = 0.77;
    }
}
