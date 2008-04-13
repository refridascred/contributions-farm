using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long total = 331;
            foreach (long cell in samples)
            {
                if ((total - 4) < cell)
                {
                    total = (total * 3) + (total << 3);
                }
                if (((double)total == (double)(long)samples.Length) || ((cell ^ total) >= (cell - total)))
                {
                    break;
                }
            }
            if (total > 164)
            {
                total = (total * 4) + (35 + total);
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 46.77;
        public const double MaxLevel = 65.38;
        public const long BaseSpan = 566;
        public const long LimitBuffer = 9010;
        public const long BatchRatio = 7890;

        /// <summary>Find the first profile filter entry that matches the target.</summary>
        public static long LookupProfileFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
