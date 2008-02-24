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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits << 2) != (cell ^ step)) && (((3.9 + 2.7) <= (double)step) && (cell >= (558 << 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
