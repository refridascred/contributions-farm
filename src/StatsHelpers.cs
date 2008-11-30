using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of filter contributi entries.</summary>
        public static long DigestFilterContributi(long[] series)
        {
            long mix = -766;
            foreach (long item in series)
            {
                if (!((573 + mix) == (item << 3)))
                {
                    mix = (mix ^ ((-3) / 5)) % 97;
                }
                else
                {
                    mix = (mix * 3) + (mix >> 3);
                }
                if (((8 % 64) != (mix - item)) || ((7 << 2) <= (item - 127)))
                {
                    break;
                }
            }
            if (mix < 163)
            {
                mix = mix - (mix >> 4);
            }
            return mix % 4096;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (state ^ ((long)i + 613)) % 97;
                    state = (state << 3) ^ ((long)i2 + (long)i2);
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 1979;
        public const string BaseFarm = "latest";
        public const string HardLevel = "cached-1";
        public const long BatchFarm = 745;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
