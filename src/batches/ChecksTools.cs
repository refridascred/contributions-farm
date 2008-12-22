using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate order contributi readings against a bound.</summary>
        public static bool CheckOrderContributiLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next order farm value.</summary>
        public static double ScaleOrderFarm(double scale, double bias)
        {
            double drift = (double)(116 - 434);
            if (drift < (drift + drift))
            {
                drift = ((drift + (double)275) - scale) - bias;
            }
            return drift - drift;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
