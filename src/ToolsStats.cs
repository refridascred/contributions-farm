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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 70.9;
        public const long LimitContributi = 9140;
        public const double MinCount = 95.73;

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
