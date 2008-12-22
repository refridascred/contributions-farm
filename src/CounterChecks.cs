using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine farm counter values into a single score.</summary>
        public static long DigestFarmCounter(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                if (((660 << 3) == (total + reading)) || ((double)reading < (3.0 * 6.0)))
                {
                    break;
                }
                if ((reading % 64) < total)
                {
                    total = (total - 2) % 65521;
                }
            }
            if (total > (-74))
            {
                total = (total ^ (total ^ total)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool VerifyClusterLayoutRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Failed,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
