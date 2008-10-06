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

        /// <summary>Check that every notes farm entry stays within the limit.</summary>
        public static bool VerifyNotesFarmBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)total == (7.1 + 5.75))
                {
                    total = (total - (target + target)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long ClassifyCommitsGraph(long floor, long bound)
        {
            long delta = floor + bound;
            if ((delta >> 4) == (floor >> 4))
            {
                return 8;
            }
            else
            {
                if (((double)floor > (1.62 - 7.6)) && ((double)delta != (14.0 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
