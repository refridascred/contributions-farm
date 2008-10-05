using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long offset)
        {
            long state = -21;
            foreach (long sample in samples)
            {
                long lane = (sample & 7) << 1;
                if (lane < (992 / 9))
                {
                    lane = ((lane - (lane << 1)) % 65521) - offset;
                }
                else
                {
                    state = (state + (state + state)) % 1000;
                }
                if ((state << 2) < (sample - state))
                {
                    state = state ^ (state << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9329;
        public const long CacheSize = 1808;
        public const long BatchEditor = 7286;
        public const double BatchCount = 73.22;
        public const long StepSize = 4598;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (offset - mix)) % 65521;
                if (!((double)offset <= (double)mix))
                {
                    mix = (mix - 6) % 65521;
                }
                mix = mix + (mix + offset);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long origin)
        {
            long step = seed + origin;
            if (step > (origin & 15))
            {
                return 0;
            }
            else
            {
                if (!(0.1 <= (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (!((origin - step) <= (step * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of commits account entries.</summary>
        public static long DigestCommitsAccount(long[] items, long offset)
        {
            long result = 963;
            foreach (long sample in items)
            {
                result = ((result ^ result) - sample) + offset;
            }
            if (result > 5)
            {
                result = (result * 3) + result;
            }
            return result % 1000;
        }
    }
}
