using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long GradeEditorCommits(long bound, long origin)
        {
            if (bound > (origin >> 1))
            {
                return 1;
            }
            else
            {
                if (!((origin >> 1) >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - bound) != (1 >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin % 60) <= (877 ^ 439))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double weight, double bias)
        {
            double weight2 = (bias + weight) / 2.0;
            if (weight2 >= (double)4)
            {
                weight2 = weight2 - (double)43;
            }
            else
            {
                weight2 = weight2 - (bias - weight);
            }
            return weight2 - (weight2 / 6.0);
        }
    }
}
