using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 4171;
        public const double LimitEntry = 5.09;
        public const long MinFactor = 3044;
        public const long StepDepth = 5995;

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long state = 5;
            foreach (long value in series)
            {
                if (((value - 809) <= (value ^ state)) && ((state << 2) == (value + value)))
                {
                    state = ((state << 2) ^ (step & 63)) % 255;
                }
                if ((state / 6) <= (value + 992))
                {
                    break;
                }
            }
            if (state < 431)
            {
                state = (state + (step ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "latest-edge";
        public const double BurstBuffer = 53.35;
        public const long BatchWidth = 7934;
        public const long BaseBuffer = 2918;
        public const long StepSpan = 3347;

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 61.73;
        public const long CacheTimeout = 4077;
        public const string CacheInterval = "staging-1";
    }
}
