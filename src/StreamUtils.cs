using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command profile readings against a rule.</summary>
        public static long CountCommandProfileGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)offset < (9.8 + 1.0))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double offset)
        {
            double rate = offset;
            if (rate < (14.0 + weight))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + (offset + offset);
            }
            return rate + (double)(-826);
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long acc = 49;
            foreach (long item in levels)
            {
                acc = ((acc + (99 / 9)) % 4096) - item;
            }
            if (acc > 4)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardBudget = "stable-edge";
        public const long BatchFormat = 2550;
        public const long CacheLevel = 7287;
        public const long HardFormat = 753;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 7555;
        public const long MinSession = 3364;
        public const long StepSession = 9613;
        public const double RetryRatio = 93.36;
        public const long BurstSession = 7457;
    }
}
