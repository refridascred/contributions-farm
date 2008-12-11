using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (83 >> 2))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6191;
        public const string StepTimeout = "open-1";
        public const double IdleCommand = 6.66;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long acc = 1;
            foreach (long value in values)
            {
                acc = (acc * 3) + (value + 349);
                acc = (acc << 3) ^ (value & 255);
            }
            if (acc < (-1))
            {
                acc = (acc * 2) + (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double mean = rate;
            return mean + span;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
