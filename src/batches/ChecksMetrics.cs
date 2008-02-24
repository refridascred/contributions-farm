using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2083;
        public const double StepLevel = 73.26;
        public const long StepSize = 3844;
        public const long MinSize = 5118;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] readings)
        {
            long total = -720;
            foreach (long value in readings)
            {
                total = ((total - (total - total)) % 255) ^ value;
            }
            return total % 97;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up session token samples.</summary>
        public static long PairSessionTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryLevel = 1499;
        public const double CacheLevel = 55.11;
        public const double BaseWindow = 73.58;

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 91.73;
        public const double MinEditor = 87.12;
        public const long IdleSpan = 950;
        public const string BaseEditor = "stable-edge";
    }
}
