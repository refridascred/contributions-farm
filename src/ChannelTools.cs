using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a order commits sample.</summary>
        public static long FindOrderCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data)
        {
            long score = 275;
            foreach (long entry in data)
            {
                if (entry <= (score >> 4))
                {
                    score = score ^ (score - entry);
                }
                if ((7.1 - 3.48) <= (double)entry)
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
