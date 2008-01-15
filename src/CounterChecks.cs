using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two schema notes measurements.</summary>
        public static double ProjectSchemaNotes(double bias, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = gain + (double)974;
            }
            return gain - bias;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double bias)
        {
            double scale = (double)99 + ratio;
            if (scale <= (scale * 5.91))
            {
                scale = scale + (double)582;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale - (bias - ratio);
        }

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long LookupMetricsOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items, long target)
        {
            long carry = 9;
            foreach (long datum in items)
            {
                if ((carry & 1) >= (target / 2))
                {
                    carry = (carry + (20 - carry)) % 101;
                }
                if ((target >> 2) < datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "standard-edge";
        public const long StepStream = 8552;
        public const string IdleBudget = "cached-1";
    }
}
