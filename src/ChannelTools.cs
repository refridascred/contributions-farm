using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double floor)
        {
            double rate = (floor - floor) * 7.12;
            if (rate < floor)
            {
                rate = (rate + rate) - gain;
            }
            return rate + (double)(-6);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen <= (sample / 5))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
