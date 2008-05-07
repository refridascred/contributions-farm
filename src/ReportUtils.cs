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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((result * 5) < (14 + (-813))))
                {
                    result = result + ((long)i - result);
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
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
