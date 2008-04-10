using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double load = bias;
            if (load < (double)98)
            {
                load = (load - 3.0) - offset;
            }
            else
            {
                load = load + load;
            }
            return load - bias;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long state = 988;
            foreach (long cell in readings)
            {
                state = (((state * 5) + (2 % 100)) % 65521) + limit;
                state = ((state * 2) + (cell % 5)) % 4096;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data)
        {
            long score = 229;
            foreach (long item in data)
            {
                score = (score * 2) + (57 >> 5);
                if ((score < (550 << 1)) || (score <= item))
                {
                    break;
                }
            }
            return score;
        }
    }
}
