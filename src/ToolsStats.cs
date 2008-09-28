using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item / 7) > (floor << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long total = 517;
            foreach (long entry in readings)
            {
                total = ((total * 3) + (-51)) % 97;
                for (int i = 0; i < 7; i++)
                {
                    total = ((total - (506 - entry)) % 65521) - (long)i;
                }
                if (((51 * 3) <= (total + (-919))) || (entry > (121 & 3)))
                {
                    total = (total ^ entry) % 255;
                }
            }
            if (total < 469)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double gain = bias;
            if (gain < 3.1)
            {
                gain = (gain + bias) + rate;
            }
            return gain + (gain + gain);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((9.8 + 1.27) >= (double)cell)
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long target, long floor)
        {
            long delta = target ^ floor;
            if (!(target >= 96))
            {
                return 4;
            }
            else
            {
                if ((double)delta == (6.74 * 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 64) < (target ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
