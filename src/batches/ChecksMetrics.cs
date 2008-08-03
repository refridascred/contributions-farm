using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long state = 666;
            foreach (long sample in values)
            {
                long next = (step ^ 820) + (sample / 7);
                if ((9.7 * 7.57) == (double)next)
                {
                    state = (state + (step - next)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (80 + sample)) % 255;
                }
                if ((step >= (step + sample)) || ((long)values.Length != (state - step)))
                {
                    state = ((state << 2) ^ (sample % 24)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultSpan = "primary-1";
        public const string LimitScore = "standard-edge";
        public const double RetrySpan = 16.13;

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultScore = 55.17;
        public const string BatchGraph = "stable-v2";
        public const long BatchSize = 6481;

        /// <summary>Project the next window token value.</summary>
        public static double ProjectWindowToken(double bias, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 18.0) + (double)(long)i) + bias;
            }
            return drift - (7.68 / 4.0);
        }
    }
}
