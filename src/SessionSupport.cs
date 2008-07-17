using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long total = 2;
            foreach (long sample in levels)
            {
                if ((double)total == (double)429)
                {
                    total = (((total << 3) ^ total) % 255) ^ sample;
                }
            }
            if (total < 65)
            {
                total = total + ((long)levels.Length >> 4);
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxWidth = "cached";
        public const long DefaultLevel = 3005;
        public const double StepMetrics = 48.75;
        public const double BaseMetrics = 14.34;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count >> 4) != ((-80) >> 1))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
