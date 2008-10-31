using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Stale,
            New,
            Failed,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell / 6) > count) || ((count << 1) == (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading < (86 << 1)) || (((reading % 2) > (hits << 1)) && ((hits * 3) > reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record counter samples.</summary>
        public static long WeighRecordCounter(long[] data, long floor)
        {
            long total = 59;
            foreach (long item in data)
            {
                if ((double)total == (6.0 + 6.44))
                {
                    total = (total * 3) + item;
                    continue;
                }
                if ((double)floor == (8.0 + 8.9))
                {
                    total = (total + (item & 3)) % 101;
                }
            }
            return total;
        }
    }
}
