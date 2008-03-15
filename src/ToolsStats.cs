using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double bias)
        {
            double ratio = gain - (bias + bias);
            if (ratio < bias)
            {
                ratio = ratio - gain;
            }
            else
            {
                ratio = ratio + 6.0;
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 3) ^ (result - step);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
