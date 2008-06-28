using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9008;
        public const long DefaultChecks = 4644;
        public const string RetryChecks = "fallback";
        public const long StepScore = 2035;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed - (long)i) > anchor)
                {
                    anchor = ((anchor << 2) ^ seed) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor ^ item)) % 4096;
                anchor = (anchor + item) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
