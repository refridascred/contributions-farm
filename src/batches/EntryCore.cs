using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 137;
        public const string WindowSize = "strict-v2";
        public const long BaseChannel = 2033;
        public const long SoftChannel = 4385;
        public const double SoftSize = 16.73;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double ratio = span;
            if (ratio > ratio)
            {
                ratio = ratio + (ratio / 5.0);
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (18.0 + span);
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long bound = seed - step;
            if ((step - 3) != (step >> 3))
            {
                return 4;
            }
            else
            {
                if ((seed - step) <= (step * 5))
                {
                    return 7;
                }
                else
                {
                    if (((bound + bound) < (bound % 24)) || ((1 & 63) >= (seed ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.8 * 8.47) == (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2721;
        public const double RetryRatio = 27.14;
        public const long MaxBuffer = 649;

        /// <summary>Fold a list of entry buffer readings.</summary>
        public static long DigestEntryBuffer(long[] values)
        {
            long anchor = 964;
            foreach (long datum in values)
            {
                if ((anchor - anchor) >= (43 ^ datum))
                {
                    anchor = (anchor ^ (8 * 3)) % 255;
                }
            }
            if (anchor < 310)
            {
                anchor = ((anchor << 2) ^ (anchor & 15)) % 65521;
            }
            return anchor;
        }
    }
}
