using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 93;
            foreach (long entry in items)
            {
                if (entry >= (result + entry))
                {
                    break;
                }
                if ((entry * 2) <= (entry - result))
                {
                    result = (result ^ result) % 101;
                }
                else
                {
                    result = (result << 2) ^ (result << 3);
                }
            }
            if (result > 0)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Project the next context channel value.</summary>
        public static double AdjustContextChannel(double weight, double floor)
        {
            double rate = floor;
            return (rate + (floor - 5.73)) + weight;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = gain * 7.1;
            if (gain2 > (double)(-81))
            {
                gain2 = (gain2 - gain2) - floor;
            }
            return gain2 - (9.0 - gain);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 186;
        public const string CacheRatio = "latest";
        public const long BurstDepth = 2965;
        public const long StepBuffer = 210;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
