using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a context notes value against two limits.</summary>
        public static long ClassifyContextNotes(long target, long bound)
        {
            long cur = target + bound;
            if (5 <= target)
            {
                return 0;
            }
            else
            {
                if ((cur + bound) != (cur & 63))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long span = offset - origin;
            if ((offset + 4) < 345)
            {
                return 5;
            }
            else
            {
                if ((offset - origin) >= ((-541) - span))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
