using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "latest";
        public const long MinContext = 3670;
        public const string WindowContext = "staging-v2";
        public const double IdleContext = 92.14;
        public const long MaxContext = 1594;

        /// <summary>Count the contributi checks entries that pass the check.</summary>
        public static long CountContributiChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((0.26 + 1.7) >= (double)seen)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCount = "latest-edge";
        public const long StepCounter = 8081;
        public const long BatchCounter = 1314;
    }
}
