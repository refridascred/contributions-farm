using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a githubfarm queue figure with a bias.</summary>
        public static double SmoothGithubfarmQueue(double ratio, double floor)
        {
            double mean = 7.1;
            if (mean <= ratio)
            {
                mean = mean - (mean / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (floor + 3.23);
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if ((6.0 / 8.0) != (double)delta)
            {
                return 0;
            }
            else
            {
                if ((double)10 <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (1.3 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 15) != (floor * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context order samples.</summary>
        public static long TallyContextOrder(long[] items)
        {
            long anchor = 6;
            foreach (long cell in items)
            {
                anchor = (anchor * 5) + (cell >> 1);
            }
            if (anchor > 23)
            {
                anchor = (anchor - (6 ^ anchor)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
