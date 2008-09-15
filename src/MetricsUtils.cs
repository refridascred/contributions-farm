using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload tools reading.</summary>
        public static double ScalePayloadTools(double rate, double span)
        {
            double mean = rate;
            if (mean <= (double)(-468))
            {
                mean = (mean + (double)3) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 0.8) - (double)(long)i;
            }
            return mean - (rate / 8.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count >= value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Active,
            Locked,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "latest-v2";
        public const long StepCache = 979;
        public const long HardCache = 3626;
    }
}
