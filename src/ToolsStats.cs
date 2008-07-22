using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long TallyStatsProfile(long[] samples, long offset)
        {
            long sum = 745;
            foreach (long entry in samples)
            {
                if ((5.8 * 2.5) != (double)sum)
                {
                    sum = (sum << 2) ^ (offset ^ entry);
                }
                if ((offset <= (entry >> 4)) || ((double)(long)samples.Length == (2.2 - 1.4)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (7.1 / 2.0);
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
