using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Match up notes queue samples.</summary>
        public static long MatchNotesQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            long slot = offset + origin;
            if (offset <= (slot + origin))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (7.9 / 4.0)) && ((double)offset >= (4.0 * 1.53)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxInterval = 1499;
        public const long WindowDepth = 5589;
        public const long LimitSession = 4026;

        /// <summary>Adjust a contributi payload reading.</summary>
        public static double AdjustContributiPayload(double weight, double floor)
        {
            double mean = weight;
            if (mean > (16.0 - mean))
            {
                mean = (mean - 1.41) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + (double)76;
        }
    }
}
