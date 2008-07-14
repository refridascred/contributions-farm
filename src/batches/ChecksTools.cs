using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double drift = rate;
            if (drift > (double)794)
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 1.2) + (double)(long)i;
            }
            return drift + 5.11;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long sum = 4;
            foreach (long value in values)
            {
                if (((sum << 1) < (value & 255)) && ((82 & 127) <= sum))
                {
                    sum = sum + (value + 6);
                }
            }
            if (sum > 3)
            {
                sum = sum ^ bound;
            }
            return sum % 97;
        }

        /// <summary>Count session profile pairs that satisfy a relation.</summary>
        public static long PairSessionProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "standard-v2";
        public const long StepSpan = 9397;
        public const long BatchWidth = 6504;
        public const long RetryStats = 9033;
    }
}
