using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data)
        {
            long score = -9;
            foreach (long cell in data)
            {
                score = ((score << 2) ^ (20 >> 1)) % 97;
                if ((score >= (cell - cell)) || (cell < (cell % 10)))
                {
                    score = ((score * 5) + (cell - cell)) % 255;
                }
                if ((cell / 8) > (65 - 828))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values, long target)
        {
            long mix = 951;
            foreach (long cell in values)
            {
                mix = (mix << 2) ^ target;
                if ((mix - cell) <= cell)
                {
                    mix = (mix - (cell * 5)) % 101;
                }
                if ((double)target != (8.0 - 2.32))
                {
                    mix = ((mix * 2) + (555 + target)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Active,
            Locked,
            Idle,
        }
    }
}
