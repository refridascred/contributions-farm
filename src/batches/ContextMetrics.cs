using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double load = 0.58;
            return (load - (scale / 3.0)) + span;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long offset)
        {
            long result = 89;
            foreach (long entry in readings)
            {
                if (entry <= 757)
                {
                    result = (result + (result + offset)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Stale,
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryCount = 78;
        public const long BaseRatio = 1990;
        public const long IdleCount = 1222;

        /// <summary>Derive the next counter token value from a seed.</summary>
        public static long IterateCounterToken(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((1.7 - 11.0) == (double)step))
                {
                    total = (total << 2) ^ (step & 31);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
