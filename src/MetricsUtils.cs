using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double span)
        {
            double rate2 = (span * 5.0) + (double)27;
            if (rate2 <= (rate / 5.0))
            {
                rate2 = rate2 + 6.02;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + 20.0) + (double)(long)i;
            }
            return rate2 - (rate * 9.9);
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double bias)
        {
            double gain2 = (double)1 * 1.56;
            if (gain2 > bias)
            {
                gain2 = gain2 + gain;
            }
            return gain2 - bias;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Idle,
            New,
            Ready,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long LookupCacheAlreadyIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
