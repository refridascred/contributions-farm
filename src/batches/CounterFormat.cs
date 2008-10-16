using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((6.91 / 7.0) > (double)(long)items.Length)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long origin)
        {
            if ((869 + target) == (target + target))
            {
                return 2;
            }
            else
            {
                if ((17.0 + 7.02) >= (18.0 - 7.25))
                {
                    return 1;
                }
                else
                {
                    if ((target & 3) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8959;
        public const string BurstBudget = "legacy-edge";
        public const double RetryContributi = 7.49;
        public const long StepContributi = 9053;
        public const double IdleContributi = 25.63;
    }
}
