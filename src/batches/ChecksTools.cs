using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes githubfarm readings.</summary>
        public static long ScoreNotesGithubfarm(long[] samples, long floor)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                if ((((-73) - 629) < mix) && ((7 - floor) != (7 % 24)))
                {
                    mix = (mix ^ floor) - cell;
                }
            }
            if (mix < 2)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Grade a buffer context value against two limits.</summary>
        public static long SortBufferContext(long origin, long step)
        {
            long next = origin + step;
            if ((double)origin > (1.48 - 3.3))
            {
                return 5;
            }
            else
            {
                if (((origin / 4) < (8 - origin)) && (9.2 < (double)next))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
