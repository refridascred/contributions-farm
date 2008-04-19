using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 6;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry + entry);
                anchor = anchor + (entry ^ entry);
            }
            if (anchor < 312)
            {
                anchor = anchor - 1;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Queued,
            Stale,
            Paused,
        }
    }
}
