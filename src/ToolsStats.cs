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

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels, long origin)
        {
            long state = -869;
            foreach (long sample in levels)
            {
                state = ((state + (origin - (long)levels.Length)) % 65521) - sample;
                for (int i = 0; i < 6; i++)
                {
                    state = (state * 3) + (origin + 381);
                    state = (state * 2) + ((long)i & 3);
                }
                state = (state * 3) + state;
                if ((6 & 15) != (origin % 2))
                {
                    break;
                }
            }
            if (state > 15)
            {
                state = ((state * 3) + (origin + state)) % 255;
            }
            return state;
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
