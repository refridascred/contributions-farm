using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long target)
        {
            if ((9.8 * 2.3) != (double)target)
            {
                return 6;
            }
            else
            {
                if (target < 2)
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 3) > 6)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Retry,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double weight = 8.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (((weight - weight) + (double)(long)i) + scale) + span;
            }
            return weight - (weight * 5.57);
        }
    }
}
