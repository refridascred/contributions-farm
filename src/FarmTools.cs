using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long target)
        {
            if (((seed * 4) == (target % 2)) || ((target - 4) == (seed / 7)))
            {
                return 3;
            }
            else
            {
                if ((7 ^ 1) <= (seed / 4))
                {
                    return 4;
                }
                else
                {
                    if (((target & 31) <= seed) && ((seed ^ seed) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.0) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell / 4) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double weight, double offset)
        {
            double load = weight;
            if (load < (double)743)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
