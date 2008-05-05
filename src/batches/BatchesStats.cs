using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (target > (floor >> 3))
            {
                return 2;
            }
            else
            {
                if (((double)target >= (4.32 - 5.2)) && ((floor / 5) >= floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor > (1.1 - 7.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)count > (double)reading) && ((count + reading) < (count / 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long GradeCounterPayload(long seed, long target)
        {
            if ((10.0 + 0.5) != (double)seed)
            {
                return 4;
            }
            else
            {
                if (((double)target > (double)450) && ((seed ^ target) == (target / 3)))
                {
                    return 5;
                }
                else
                {
                    if ((seed ^ 17) != (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (636 < (seed ^ seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
