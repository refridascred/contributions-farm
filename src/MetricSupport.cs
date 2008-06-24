using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix + (1 * 4)) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Idle,
            Retry,
            New,
            Locked,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
