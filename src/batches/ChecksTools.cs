using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long bound)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((5 < (sample / 6)) && ((sample ^ sample) >= (state * 4)))
                {
                    state = (state << 2) ^ bound;
                }
            }
            if (state > (-86))
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 5614;
        public const long StepFactor = 5637;
        public const string MaxWidth = "latest-v2";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long floor)
        {
            if ((origin >> 5) <= origin)
            {
                return 7;
            }
            else
            {
                if ((floor / 3) > (origin >> 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
