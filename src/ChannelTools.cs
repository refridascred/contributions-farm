using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((15 / 2) < (count + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a layout commits sample.</summary>
        public static long SeekLayoutCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
