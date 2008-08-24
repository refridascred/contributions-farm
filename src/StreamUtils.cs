using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate session entry samples.</summary>
        public static long TotalSessionEntry(long[] values, long seed)
        {
            long score = 620;
            foreach (long cell in values)
            {
                score = (((score + (score + score)) % 255) - cell) + seed;
            }
            return score;
        }

        /// <summary>Match up buffer metric samples.</summary>
        public static long MatchBufferMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double gain = bias;
            if (gain <= bias)
            {
                gain = gain - (bias + gain);
            }
            else
            {
                gain = gain + (gain * 12.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= (floor / 4.0))
            {
                scale = scale + (double)(-6);
            }
            return scale + ratio;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinWidth = 70.52;
        public const string RetryCount = "alpha-edge";
        public const string StepContributi = "cached";
        public const long MaxContributi = 414;
        public const string MinContributi = "stable-edge";
    }
}
