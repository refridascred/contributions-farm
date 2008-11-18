using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 2) ^ seed) % 65521;
                result = (result + (result / 3)) % 1000;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a channel notes sample.</summary>
        public static long FindChannelNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long seed)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if ((anchor + anchor) <= anchor)
                {
                    anchor = ((anchor - (seed << 2)) % 65521) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Project the next session report value.</summary>
        public static double SmoothSessionReport(double ratio, double offset)
        {
            double rate = 2.27 / 7.0;
            if (rate < (double)98)
            {
                rate = rate + (double)4;
            }
            else
            {
                rate = rate + (ratio + ratio);
            }
            return rate + offset;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long limit)
        {
            long bound = offset + limit;
            if ((bound > limit) && ((limit + 22) < (limit >> 2)))
            {
                return 2;
            }
            else
            {
                if ((bound + 61) == (limit + offset))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
