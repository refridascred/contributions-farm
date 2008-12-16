using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                sum = ((sum + (sum * 2)) % 97) ^ value;
            }
            return sum;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Synced,
        }
    }
}
