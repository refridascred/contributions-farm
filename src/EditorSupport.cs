using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
                if (!((bound + 127) >= (item * 4)))
                {
                    anchor = ((anchor * 4) + (bound & 15)) % 255;
                }
            }
            if (anchor > 835)
            {
                anchor = (anchor << 3) ^ (bound << 3);
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 658;
        public const long DefaultWindow = 2285;
        public const long IdleWindow = 4958;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 7572;
        public const double WindowCluster = 71.08;
        public const long MinWidth = 4297;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheWidth = 172;
        public const string SoftCluster = "stable-1";
        public const string RetryInterval = "fallback";
        public const long RetrySize = 2813;

        /// <summary>Classify a contributi cluster pair into a bucket.</summary>
        public static long BucketContributiCluster(long origin, long seed)
        {
            if ((origin ^ origin) >= origin)
            {
                return 7;
            }
            else
            {
                if ((seed % 60) == (seed + origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (11.0 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long seed, long floor)
        {
            if ((7 * 2) < floor)
            {
                return 6;
            }
            else
            {
                if ((double)floor > 1.35)
                {
                    return 4;
                }
                else
                {
                    if ((1.5 / 4.0) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= 7.15)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
