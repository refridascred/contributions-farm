using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a record metrics pair into a bucket.</summary>
        public static long SortRecordMetrics(long floor, long origin)
        {
            long edge = floor - origin;
            if (!(floor < (floor / 4)))
            {
                return 4;
            }
            else
            {
                if (((double)floor == (9.0 + 2.6)) || ((edge + origin) != (origin + edge)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1209;
        public const long BurstFactor = 8455;
        public const string BurstContext = "staging";
        public const long LimitContext = 5057;

        /// <summary>Project the next stream farm value.</summary>
        public static double ScaleStreamFarm(double ratio, double floor)
        {
            double ratio2 = 0.2;
            if (ratio2 >= 2.36)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (9.15 + ratio2)) - (double)(long)i;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = (double)(852 * 3);
            if (gain >= span)
            {
                gain = gain - (gain / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 4.0)) + (double)(long)i;
            }
            return gain + (gain - span);
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double drift = span;
            return (drift - (double)95) + bias;
        }
    }
}
