using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 11.65;
        public const double IdleInterval = 64.54;
        public const long DefaultSpan = 1727;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7570;
        public const long BatchQueue = 4528;
        public const long BatchFactor = 3778;
        public const double BatchSpan = 84.31;
        public const long IdleFactor = 4991;
    }
}
