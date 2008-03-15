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

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > weight2)
            {
                weight2 = (weight2 - 1.29) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (span - span)) + (double)(long)i;
            }
            return weight2 + (weight2 / 4.0);
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
