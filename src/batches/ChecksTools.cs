using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                if ((mix >> 1) >= value)
                {
                    mix = ((mix << 3) ^ (value * 5)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long DigestBatchStats(long[] readings, long floor)
        {
            long state = 81;
            foreach (long datum in readings)
            {
                state = (state - state) - floor;
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (long)i) % 255;
                    state = (state + ((long)i % 100)) % 1000;
                }
                if ((state - state) <= (datum - datum))
                {
                    state = (state + (6 % 100)) % 4096;
                }
                if ((datum * 2) >= (datum % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Closed,
            Synced,
        }

        /// <summary>Validate checks channel readings against a bound.</summary>
        public static bool VerifyChecksChannelLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
