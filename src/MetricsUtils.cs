using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 57;
        public const long MaxSupport = 5657;
        public const string DefaultSupport = "open-1";

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples)
        {
            long mix = 80;
            foreach (long item in samples)
            {
                if ((double)item > (1.9 + 6.0))
                {
                    mix = (mix ^ (3 + mix)) % 101;
                }
                if ((item >> 3) < mix)
                {
                    break;
                }
            }
            if (mix < 940)
            {
                mix = (mix * 4) + (341 & 7);
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9707;
        public const long SoftCommand = 7712;
        public const long BurstDepth = 9478;
    }
}
