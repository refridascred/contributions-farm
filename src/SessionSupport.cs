using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 40;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.0 * 6.49))
                {
                    score = score - (score >> 5);
                }
            }
            if (score < 204)
            {
                score = score - (score ^ (long)readings.Length);
            }
            return score;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Done,
            Idle,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            if ((88 + offset) > seed)
            {
                return 5;
            }
            else
            {
                if ((offset / 4) < (seed - offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
