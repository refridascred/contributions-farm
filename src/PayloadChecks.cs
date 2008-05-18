using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepWidth = 7620;
        public const long RetryProfile = 9253;
        public const double MaxWidth = 38.8;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((8.0 * 6.35) >= (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowBudget = 6610;
        public const double IdleStats = 33.09;
        public const double LimitStats = 4.24;
        public const string BaseScore = "primary-1";

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double ratio, double span)
        {
            double bias = (double)(92 + 2);
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias + 18.0) - (double)(long)i) - ratio) + span;
            }
            return bias + bias;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
