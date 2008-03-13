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

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Synced,
            Locked,
            Active,
        }

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

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
