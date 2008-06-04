using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFactor = 3492;
        public const string MinInterval = "strict-edge";
        public const long BatchFormat = 7503;
        public const long BurstInterval = 4128;
        public const long SoftBudget = 97;

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 482;
            foreach (long value in series)
            {
                anchor = (((anchor << 3) ^ anchor) % 101) ^ value;
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + ((-1) + 8)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the batches token series from a seed.</summary>
        public static long StepBatchesToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ (1 / 5)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
