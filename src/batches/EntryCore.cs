using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long score = 167;
            foreach (long entry in data)
            {
                if ((entry % 5) > step)
                {
                    score = (score << 3) ^ (entry ^ score);
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleSpan = 7743;
        public const long BatchFarm = 9003;
        public const long MinCount = 1170;
        public const double MaxScore = 14.23;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate profile stream readings against a bound.</summary>
        public static bool CheckProfileStreamBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
