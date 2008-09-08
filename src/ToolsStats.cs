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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches < 3.0)
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double bias)
        {
            double drift = gain;
            return drift + (bias * 9.1);
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
