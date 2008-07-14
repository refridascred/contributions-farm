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

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels)
        {
            long carry = 40;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = carry ^ (carry + (long)i);
                }
                if (((double)23 <= (double)carry) || ((long)levels.Length == (entry >> 1)))
                {
                    carry = carry + (carry / 9);
                }
            }
            return carry;
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
