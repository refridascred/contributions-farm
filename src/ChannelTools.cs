using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-edge";
        public const string LimitEntry = "stable";
        public const long BurstSpan = 3540;
        public const string StepEntry = "alpha-v2";

        /// <summary>Check that every cache session entry stays within the limit.</summary>
        public static bool VerifyCacheSessionRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count tools metric pairs that satisfy a relation.</summary>
        public static long PairToolsMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
