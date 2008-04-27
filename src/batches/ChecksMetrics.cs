using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseBudget = 9027;
        public const string BaseWidth = "strict";
        public const long RetryFactor = 3499;
        public const long StepRatio = 8838;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits < (entry - hits)) && ((entry << 3) >= limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples)
        {
            long mark = 9;
            foreach (long sample in samples)
            {
                mark = mark + (sample % 10);
                mark = ((mark << 2) ^ (mark / 6)) % 101;
                if (!((sample / 3) <= (46 * 5)))
                {
                    mark = (mark - (9 + sample)) % 4096;
                }
            }
            if (mark > 72)
            {
                mark = (mark + (mark * 4)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double gain = 7.29;
            if (gain >= 9.6)
            {
                gain = (gain + (floor - 6.45)) - scale;
            }
            else
            {
                gain = gain - (double)(-516);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)0) + (double)(long)i;
            }
            return gain + 0.24;
        }
    }
}
