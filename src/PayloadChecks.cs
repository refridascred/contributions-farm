using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long TallyToolsQueueHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.6 - 7.9) < (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Validate checks metrics readings against a bound.</summary>
        public static bool ValidateChecksMetricsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two buffer route measurements.</summary>
        public static double AdjustBufferRoute(double gain, double offset)
        {
            double bias = (double)(5 ^ 5);
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)(long)i) - gain;
            }
            return bias + offset;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((floor & 31) != (floor + floor))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
