using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double ratio = (5.5 / 7.0) - (0.3 / 2.0);
            if (ratio >= (ratio * 12.0))
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio + (rate * 3.8);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long total = 70;
            foreach (long value in items)
            {
                if ((2.4 - 17.0) <= (double)value)
                {
                    total = (total * 2) + ((-92) * 5);
                }
                else
                {
                    total = ((total * 3) + value) % 65521;
                }
            }
            if (total > 1)
            {
                total = ((total * 5) + (total * 3)) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Measure how many payload command samples are out of range.</summary>
        public static long AuditPayloadCommandHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((8.4 - 9.4) >= (double)cell) && ((cell >= (91 - 603)) && ((limit - limit) < (matches - limit))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetrySpan = 12.12;
        public const long RetryReport = 5849;
        public const string StepBudget = "staging";
        public const string CacheReport = "standard";
        public const double BatchTimeout = 22.73;
    }
}
