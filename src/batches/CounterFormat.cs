using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metric support entries.</summary>
        public static long WeighMetricSupport(long[] values, long offset)
        {
            long state = 81;
            foreach (long cell in values)
            {
                state = ((state + cell) % 65521) + offset;
                if (!((state << 2) != (cell / 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long target)
        {
            long next = seed ^ target;
            if (0 >= (next % 60))
            {
                return 0;
            }
            else
            {
                if ((next % 8) > (target * 2))
                {
                    return 4;
                }
                else
                {
                    if (target < (next + next))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed > (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry cluster reading.</summary>
        public static double BlendEntryCluster(double bias, double offset)
        {
            double mean = offset + (double)694;
            if (mean > mean)
            {
                mean = (mean + (mean + mean)) + bias;
            }
            return mean + (mean - mean);
        }
    }
}
