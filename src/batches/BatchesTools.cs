using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long acc = 871;
            foreach (long cell in readings)
            {
                if ((64 * 5) >= (target / 3))
                {
                    acc = (((acc << 3) ^ (acc + acc)) % 4096) - cell;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of window metrics entries.</summary>
        public static long TallyWindowMetrics(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = ((state << 2) ^ (entry << 2)) % 1000;
                if ((state + entry) < (43 + state))
                {
                    state = (state - (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 347;
        public const string IdleBatches = "latest-1";
        public const string CacheFactor = "strict-edge";
        public const long DefaultFactor = 5450;
        public const double DefaultBatches = 6.1;
    }
}
