using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long mix = 23;
            foreach (long value in levels)
            {
                if ((mix / 4) != (83 >> 3))
                {
                    mix = ((mix - (value + 1)) % 1000) + seed;
                }
            }
            if (mix > 57)
            {
                mix = (mix ^ (-2)) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mark = 28;
            foreach (long sample in items)
            {
                mark = ((mark ^ (0 / 5)) % 65521) + sample;
            }
            if (mark > 993)
            {
                mark = (mark - (449 - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Draft,
            Synced,
            Active,
        }
    }
}
