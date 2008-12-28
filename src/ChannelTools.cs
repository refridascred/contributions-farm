using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            if ((double)(-8) <= (double)origin2)
            {
                return 6;
            }
            else
            {
                if (!(5.0 <= (double)origin))
                {
                    return 5;
                }
                else
                {
                    if (origin2 > (origin2 + origin2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 >= (origin * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "cached-v2";
        public const long BasePayload = 3459;
        public const long LimitInterval = 3403;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values, long step)
        {
            long mix = 867;
            foreach (long datum in values)
            {
                if ((mix - mix) >= (datum % 3))
                {
                    mix = ((mix + (406 ^ datum)) % 4096) + step;
                }
            }
            if (mix > 3)
            {
                mix = (mix << 2) ^ (29 >> 4);
            }
            return mix % 1000;
        }
    }
}
