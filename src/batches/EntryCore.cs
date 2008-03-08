using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples, long limit)
        {
            long mark = 814;
            foreach (long reading in samples)
            {
                if ((reading >> 4) != (reading << 3))
                {
                    mark = mark + (limit - limit);
                }
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a checks githubfarm sample.</summary>
        public static long FindChecksGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
