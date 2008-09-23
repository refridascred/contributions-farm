using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate context already samples.</summary>
        public static long TotalContextAlready(long[] levels, long seed)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                mix = ((mix ^ mix) % 97) + seed;
                if ((double)item > 12.0)
                {
                    mix = mix + (mix ^ item);
                }
            }
            if (mix > (-27))
            {
                mix = ((mix * 3) + mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long RankSessionContributi(long target, long floor)
        {
            if (floor > (target ^ target))
            {
                return 6;
            }
            else
            {
                if (0.5 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of cluster format readings.</summary>
        public static long TallyClusterFormat(long[] levels, long origin)
        {
            long acc = -31;
            foreach (long datum in levels)
            {
                acc = (acc - datum) - origin;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((acc * 2) < ((long)i + (long)i))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
