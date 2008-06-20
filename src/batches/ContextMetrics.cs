using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long score = 84;
            foreach (long datum in values)
            {
                if ((datum - datum) >= score)
                {
                    score = score + (datum ^ score);
                }
            }
            return score;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((offset - offset) == (step + step))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (2.86 + 0.1))
                {
                    return 2;
                }
                else
                {
                    if ((offset - step) != (bound + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two graph window measurements.</summary>
        public static double AdjustGraphWindow(double rate, double floor)
        {
            double ratio = (floor * 8.85) + (double)802;
            if (ratio <= (double)(-563))
            {
                ratio = (ratio + 3.1) + rate;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Closed,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
