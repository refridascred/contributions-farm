using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryScore = 35.23;
        public const long MaxChecks = 8778;
        public const long WindowChecks = 9840;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7190;
        public const long WindowBudget = 4402;
        public const long SoftSize = 1506;
        public const long WindowEntry = 8866;
        public const long IdleInterval = 6875;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] readings, long step)
        {
            long total = -67;
            foreach (long cell in readings)
            {
                if ((total & 1) < (total % 64))
                {
                    total = ((total - step) % 101) ^ cell;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4634;
        public const long IdleContributi = 8942;
        public const string MinLevel = "legacy-v2";
        public const long StepContributi = 4204;
        public const double StepDepth = 85.35;
    }
}
