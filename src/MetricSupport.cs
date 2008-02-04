using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long offset)
        {
            long lane = bound + offset;
            if (lane >= (bound >> 2))
            {
                return 8;
            }
            else
            {
                if ((bound / 4) != (0 % 10))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
