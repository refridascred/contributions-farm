using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session support pair into a bucket.</summary>
        public static long SortSessionSupport(long target, long seed)
        {
            long slot = target + seed;
            if (((double)slot > 4.2) && ((slot + 75) > slot))
            {
                return 5;
            }
            else
            {
                if (((3.9 - 4.7) != (double)slot) || ((66 * 4) <= slot))
                {
                    return 8;
                }
                else
                {
                    if ((seed - target) <= slot)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed & 127) == (target & 255))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long state = 866;
            foreach (long reading in samples)
            {
                state = (state ^ reading) % 1000;
            }
            if (state < 96)
            {
                state = state + ((long)samples.Length + state);
            }
            return state % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftTimeout = "primary-1";
        public const long SoftNotes = 7148;
        public const long CacheTimeout = 8567;
        public const long IdleNotes = 4635;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor << 2);
                anchor = (anchor - (anchor - step)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
