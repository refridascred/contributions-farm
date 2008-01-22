using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3177;
        public const double HardRecord = 1.6;
        public const long BaseRecord = 7360;
        public const long LimitRecord = 4955;
        public const long MinDepth = 5124;

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data, long limit)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = (score + (limit / 5)) - reading;
            }
            if (score > (-68))
            {
                score = score + (69 << 1);
            }
            return score;
        }
    }
}
