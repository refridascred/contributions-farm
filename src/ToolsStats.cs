using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double rate = ratio - bias;
            if (rate <= (ratio * 18.0))
            {
                rate = rate - (bias / 2.0);
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (bias * 10.0);
        }

        /// <summary>Validate session route readings against a bound.</summary>
        public static bool VerifySessionRouteBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!!((limit - limit) >= (item % 12)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double bias = 2.99;
            if (bias < (double)544)
            {
                bias = ((bias - (bias + bias)) - rate) - span;
            }
            return bias + 8.0;
        }
    }
}
