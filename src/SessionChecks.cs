using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter token readings.</summary>
        public static long CompareFilterTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] samples, long offset)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (314 + offset))
                {
                    state = ((state * 2) + (2 * 2)) % 255;
                }
            }
            if (state > 55)
            {
                state = (state ^ (state << 1)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 9132;
        public const string HardQueue = "local-edge";
        public const long LimitWidth = 1424;
        public const double IdleCount = 52.59;

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double gain, double floor)
        {
            double rate = floor;
            return (rate + (floor / 9.0)) + gain;
        }
    }
}
