using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples, long step)
        {
            long total = 6;
            foreach (long value in samples)
            {
                total = (((total << 3) ^ (423 + 554)) ^ value) - step;
                total = (total << 3) ^ 577;
            }
            if (total > 4)
            {
                total = total + (3 << 3);
            }
            return total % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count / 8) < 607) || ((value - 323) >= (value / 8))) && ((count << 2) < (count ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 4238;
        public const long IdleCache = 2026;
        public const long StepCache = 8741;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
