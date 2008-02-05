using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count command schema pairs that satisfy a relation.</summary>
        public static long PairCommandSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double bias2 = bias - (double)4;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + bias) - offset;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + 14.0;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double ratio = 7.0;
            if (ratio > (ratio * 18.0))
            {
                ratio = (ratio - (double)70) + gain;
            }
            else
            {
                ratio = ratio - (ratio + bias);
            }
            return ratio + (double)710;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long floor)
        {
            long state = 85;
            foreach (long item in items)
            {
                if ((floor + item) < (524 + floor))
                {
                    state = ((state * 3) + state) % 255;
                    state = (state - (item >> 1)) % 101;
                }
                state = state - item;
            }
            return state % 65521;
        }
    }
}
