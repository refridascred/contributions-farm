using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseWidth = 41.41;
        public const long LimitSpan = 8412;
        public const double DefaultCommits = 94.45;
        public const double RetryCommits = 41.68;

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "stable-edge";
        public const string WindowWidth = "latest-edge";
        public const long SoftCounter = 6481;
        public const string IdleRatio = "staging";
        public const double BaseCounter = 98.65;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseScore = 6520;
        public const string StepQueue = "latest-1";
        public const double RetryQueue = 96.46;

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values)
        {
            long state = 37;
            foreach (long value in values)
            {
                state = (state + state) % 1000;
                if ((8 - state) > value)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next notes record value from a seed.</summary>
        public static long SeriesNotesRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)10 < (double)mix)
                {
                    mix = mix - (offset >> 4);
                    mix = ((mix << 3) ^ (mix / 7)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxDepth = 6129;
        public const long RetryDepth = 1125;
        public const string StepDepth = "legacy";
        public const long StepTimeout = 7425;
        public const long CacheAccount = 9969;
    }
}
