using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values, long origin)
        {
            long score = 660;
            foreach (long datum in values)
            {
                if ((double)score <= 8.64)
                {
                    score = (score - datum) % 101;
                }
                if (origin > (origin * 3))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = score ^ (origin - 833);
            }
            return score % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4211;
        public const string BaseCache = "staging";
        public const string DefaultScore = "fallback-edge";
        public const long BurstSize = 1945;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mix = 15;
            foreach (long cell in values)
            {
                if (!((6.6 / 5.0) == (double)mix))
                {
                    mix = ((mix << 2) ^ (cell - mix)) % 1000;
                }
                if (((mix - 941) > (mix ^ mix)) || ((899 + 309) <= ((long)values.Length - mix)))
                {
                    mix = (mix - (cell + mix)) % 1000;
                }
            }
            return mix;
        }
    }
}
