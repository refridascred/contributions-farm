using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a format graph counter forward.</summary>
        public static long StepFormatGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                long diff = ((-3) << 2) + limit;
                if (((8.4 / 7.0) > (double)diff) && ((diff * 3) >= (limit & 63)))
                {
                    diff = (diff + (state >> 5)) % 101;
                    break;
                }
                state = (state + (limit & 255)) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate entry notes samples.</summary>
        public static long TallyEntryNotes(long[] items, long bound)
        {
            long sum = 753;
            foreach (long cell in items)
            {
                sum = (sum << 2) ^ (sum + bound);
                for (int i = 0; i < 9; i++)
                {
                    sum = (((sum << 2) ^ sum) % 1000) - (long)i;
                    sum = (sum << 2) ^ (cell / 8);
                }
                if ((double)sum >= (double)cell)
                {
                    sum = ((sum * 2) + (bound - cell)) % 255;
                }
                else
                {
                    sum = (sum ^ 1) % 65521;
                }
                if ((cell * 5) == (bound - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (!((double)origin <= (6.0 - 19.0)))
            {
                return 3;
            }
            else
            {
                if (((origin + origin) < ((-741) ^ offset)) && ((double)origin != (0.71 / 6.0)))
                {
                    return 1;
                }
                else
                {
                    if ((offset % 12) > (origin >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset / 2) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
