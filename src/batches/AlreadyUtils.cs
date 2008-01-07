using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long bound)
        {
            long gap = step + bound;
            if (!(gap < (bound + gap)))
            {
                return 5;
            }
            else
            {
                if (!((3.73 * 9.0) > (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((step + bound) < gap)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step & 127) < (bound + gap)) && ((gap + 93) != (step / 6)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Locked,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Count the route already entries that pass the check.</summary>
        public static long CountRouteAlreadyHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)hits > (double)reading) || ((double)floor > (7.8 + 6.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first schema notes entry that matches the target.</summary>
        public static long LookupSchemaNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
