using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double ratio = weight * 9.81;
            if (ratio >= (ratio / 9.0))
            {
                ratio = ratio + 16.0;
            }
            else
            {
                ratio = ratio - (double)(-596);
            }
            return ratio + span;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long limit)
        {
            if ((bound << 1) != (bound >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (1.2 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long origin)
        {
            long anchor = 774;
            foreach (long cell in readings)
            {
                if ((double)origin < (double)6)
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 1000) - cell;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Count stats filter pairs that satisfy a relation.</summary>
        public static long CompareStatsFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Active,
            Idle,
            New,
        }
    }
}
