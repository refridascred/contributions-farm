using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long state = 54;
            foreach (long sample in series)
            {
                if (!((3.0 + 0.9) > (double)sample))
                {
                    state = (state + ((long)series.Length >> 5)) % 65521;
                }
                else
                {
                    state = (state ^ ((-811) >> 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((limit << 3) <= (count >> 3))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a channel command reading.</summary>
        public static double ScaleChannelCommand(double gain, double offset)
        {
            double scale = offset;
            if (scale <= scale)
            {
                scale = (scale + (double)560) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale + offset)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items)
        {
            long carry = 91;
            foreach (long value in items)
            {
                if ((value * 3) >= (value ^ value))
                {
                    carry = (carry - 31) % 65521;
                }
            }
            return carry;
        }
    }
}
