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

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1916;
        public const string LimitWindow = "fallback-1";
        public const long IdleWindow = 4216;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Active,
            Done,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
