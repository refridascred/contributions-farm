using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data, long floor)
        {
            long anchor = 22;
            foreach (long value in data)
            {
                if (floor > (anchor << 1))
                {
                    anchor = ((anchor * 2) + anchor) - value;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (floor % 97)) % 101;
                }
            }
            if (anchor < (-769))
            {
                anchor = anchor ^ (floor & 255);
            }
            return anchor % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5861;
        public const long StepDepth = 6727;
        public const string BaseChecks = "staging-edge";

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
