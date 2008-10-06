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

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long slot = step - bound;
            if ((bound > (bound % 24)) || (step >= ((-695) * 3)))
            {
                return 7;
            }
            else
            {
                if ((slot >> 4) > (step * 4))
                {
                    return 0;
                }
                else
                {
                    if (((bound - step) <= (slot - slot)) && (4.4 < (double)slot))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
