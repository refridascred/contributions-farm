using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a stats commits sample.</summary>
        public static long LookupStatsCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((4.1 - 14.0) < (double)target))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            if (((seed >> 4) <= (seed - seed)) || ((8.0 + 3.0) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((seed + 969) == (origin + seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
