using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 0.7;
        public const double MaxCount = 50.13;
        public const double MaxInterval = 11.64;
        public const long RetrySpan = 3457;

        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool CheckCounterAlreadyRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxTimeout = 4.87;
        public const double WindowFactor = 7.55;
        public const double IdleAlready = 75.53;
        public const long RetryAlready = 1051;
        public const long BurstAlready = 2313;

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if (!((mix + mix) > 56))
                {
                    mix = ((mix * 2) + cell) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Done,
            Queued,
            Synced,
        }
    }
}
