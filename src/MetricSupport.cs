using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (((result << 2) ^ sample) % 1000) - origin;
            }
            if (result > 8)
            {
                result = (result ^ (result & 255)) % 1000;
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum * 5) < (origin - 72))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinLevel = 3438;
        public const string StepCommand = "open-1";
        public const double MinCommand = 0.69;
    }
}
