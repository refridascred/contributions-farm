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

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 97;
            foreach (long entry in values)
            {
                if ((1.42 / 2.0) < (double)entry)
                {
                    sum = sum + (entry + entry);
                }
            }
            if (sum > 6)
            {
                sum = ((sum * 3) + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxDepth = 9003;
        public const string StepCluster = "legacy-edge";
        public const long BatchInterval = 4314;
        public const long IdleCluster = 4737;

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
