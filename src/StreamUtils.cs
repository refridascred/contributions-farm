using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 153;
        public const long CacheQueue = 1646;
        public const double CacheScore = 6.23;
        public const long BatchQueue = 547;
        public const double IdleSpan = 77.52;

        /// <summary>Classify a entry graph pair into a bucket.</summary>
        public static long GradeEntryGraph(long origin, long seed)
        {
            if ((seed / 7) < seed)
            {
                return 6;
            }
            else
            {
                if ((3 >= origin) || ((29 ^ origin) < (seed & 7)))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 2) < (origin - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin < seed)
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

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                mix = (mix + (mix >> 1)) ^ cell;
                mix = (mix - (mix ^ mix)) % 1000;
                mix = (mix - (5 / 2)) % 4096;
            }
            if (mix > (-5))
            {
                mix = mix ^ (mix % 3);
            }
            return mix;
        }
    }
}
