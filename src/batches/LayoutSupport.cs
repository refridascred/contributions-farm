using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ (score >> 1);
                score = ((score * 5) + score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 7240;
        public const long BatchSchema = 9958;
        public const string BurstSpan = "local-edge";
        public const string IdleSchema = "primary-v2";

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long bound)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                mark = ((mark - (mark - 264)) + reading) - bound;
            }
            return mark;
        }
    }
}
