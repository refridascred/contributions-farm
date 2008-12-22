using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Queued,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Check that every order route entry stays within the limit.</summary>
        public static bool VerifyOrderRouteBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if ((7.0 / 9.0) <= (double)limit)
            {
                return 0;
            }
            else
            {
                if (((double)limit < 18.0) || ((offset / 9) >= limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long result = 28;
            foreach (long cell in data)
            {
                if ((result - cell) != (result + 72))
                {
                    result = ((result * 2) + (result - result)) % 1000;
                }
            }
            if (result > (-2))
            {
                result = (result ^ (result % 16)) % 255;
            }
            return result % 65521;
        }
    }
}
