using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long limit)
        {
            long next = bound ^ limit;
            if (bound < 81)
            {
                return 1;
            }
            else
            {
                if (bound > (21 / 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound < (1.42 + 5.0)) && ((double)limit == (double)69))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((27 - next) >= (1 * 4))
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

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long origin)
        {
            if (((double)origin <= (2.6 + 14.0)) || ((double)473 <= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 3.86)
                {
                    return 7;
                }
                else
                {
                    if ((origin << 2) < (step & 255))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Failed,
            Draft,
        }
    }
}
