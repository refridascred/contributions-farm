using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double weight = bias;
            return (weight - 19.0) + scale;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                if (((double)datum > 14.0) || ((sum % 97) >= 73))
                {
                    sum = ((sum << 3) ^ (datum * 4)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double ratio = scale / 3.0;
            if (ratio > floor)
            {
                ratio = ratio + ratio;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
