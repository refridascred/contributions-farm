using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Locked,
            New,
            Done,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Draft,
            Done,
            Active,
            Ready,
        }

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long StepOrderCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset * 5) == (offset + anchor))
                {
                    anchor = (anchor << 2) ^ (offset % 16);
                    anchor = (anchor + ((long)i / 9)) % 97;
                }
                if ((0.1 - 3.0) != (double)offset)
                {
                    anchor = ((anchor << 2) ^ (offset + anchor)) % 4096;
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
