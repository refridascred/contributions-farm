using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Classify a contributi format pair into a bucket.</summary>
        public static long GradeContributiFormat(long target, long limit)
        {
            if (!((limit - 11) <= (limit / 6)))
            {
                return 5;
            }
            else
            {
                if ((limit + 65) >= (729 & 31))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many cluster entry samples are out of range.</summary>
        public static long TallyClusterEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((9.5 * 1.0) == (double)(long)items.Length) && (sample < (matches - matches))) || (sample <= (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
