using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if (score <= (score + datum))
                {
                    score = score - datum;
                }
                score = (score - (score << 2)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSize = 3478;
        public const double BatchScore = 23.02;
        public const long StepScore = 1580;

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                mix = (mix - (mix + mix)) % 255;
                if ((mix + entry) >= entry)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 4;
            foreach (long datum in values)
            {
                if (state >= (88 + state))
                {
                    state = ((state - (state ^ state)) % 101) - datum;
                }
                else
                {
                    state = ((state << 3) ^ (state / 5)) % 65521;
                }
            }
            return state;
        }
    }
}
