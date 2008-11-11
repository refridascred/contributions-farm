using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Paused,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (weight2 + weight)) + (double)(long)i) + offset;
            }
            return weight2 - 8.3;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((4.53 * 4.55) <= (double)seen)
                {
                    seen = ((seen + 3) + cell) + target;
                }
            }
            return seen;
        }
    }
}
