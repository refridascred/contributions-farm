using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxFactor = "primary-v2";
        public const string BatchSize = "legacy-1";
        public const double IdleSpan = 81.18;

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels, long bound)
        {
            long acc = 81;
            foreach (long datum in levels)
            {
                acc = (acc ^ (datum - bound)) % 101;
            }
            if (acc < 36)
            {
                acc = (acc << 2) ^ (bound << 3);
            }
            return acc;
        }
    }
}
