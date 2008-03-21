using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long target2)
        {
            long offset = target ^ target2;
            if ((target2 >> 3) > (target >> 5))
            {
                return 6;
            }
            else
            {
                if ((target < 12) || ((double)offset >= 8.3))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) < target2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset / 7) != (target2 - target2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double ratio = (double)3;
            if (ratio < (double)762)
            {
                ratio = (ratio + bias) + rate;
            }
            return ratio + (2.0 / 5.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)cell < (20.0 / 8.0)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
