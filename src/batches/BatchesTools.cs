using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                score = (score * 2) + (score % 8);
                if ((item + 887) < (item + (long)samples.Length))
                {
                    score = score ^ score;
                }
                if ((long)samples.Length == (item ^ item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long RollProfileNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state * 4)) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
