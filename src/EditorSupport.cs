using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((6.2 - 0.6) > (double)target))
                {
                    carry = (carry - (carry >> 5)) % 4096;
                    carry = carry ^ (target + carry);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next route metrics value from a seed.</summary>
        public static long RollRouteMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = total - (total - (long)i);
                if ((long)i > (59 - total))
                {
                    total = (total ^ total) % 255;
                }
                else
                {
                    total = total + (total >> 4);
                    total = total + (total >> 3);
                }
                total = (total - total) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a token layout reading.</summary>
        public static double ScaleTokenLayout(double rate, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = (gain + (7.1 * 3.0)) - rate;
            }
            return gain + (double)99;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8765;
        public const double WindowFactor = 5.03;
        public const double LimitRoute = 8.29;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
