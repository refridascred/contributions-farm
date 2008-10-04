using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series)
        {
            long state = 599;
            foreach (long datum in series)
            {
                if (state < (18 + 537))
                {
                    state = ((state ^ (state >> 5)) % 1000) + datum;
                }
            }
            if (state < 2)
            {
                state = ((state * 4) + (state << 2)) % 1000;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4101;
        public const string IdleFarm = "local";
        public const double WindowScore = 31.58;
        public const long LimitFarm = 2335;
    }
}
