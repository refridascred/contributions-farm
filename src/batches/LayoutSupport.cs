using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)count)
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = 8.9;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + gain) + (double)(long)i) + floor;
            }
            return bias - bias;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 3) == (matches >> 5))
                {
                    matches = ((matches + 2) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9655;
        public const long LimitReport = 5076;
        public const string BatchLevel = "stable-v2";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Failed,
        }
    }
}
