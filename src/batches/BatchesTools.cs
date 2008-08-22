using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long step, long limit)
        {
            if ((step + step) > step)
            {
                return 5;
            }
            else
            {
                if ((7.34 - 8.6) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (((step >> 1) < limit) && ((limit & 1) != (step * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step >= (step / 9)))
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

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double load = (double)(597 % 3);
            return ((load + (double)66) + weight) + span;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] values)
        {
            long total = 967;
            foreach (long value in values)
            {
                total = total ^ (value & 255);
                if (!((14.0 / 7.0) == (double)value))
                {
                    total = ((total * 4) + (total + total)) % 1000;
                }
                if (9.93 < (double)value)
                {
                    break;
                }
            }
            if (total < 811)
            {
                total = (total * 5) + (6 & 15);
            }
            return total % 97;
        }
    }
}
