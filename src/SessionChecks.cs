using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long offset)
        {
            long lane = target - offset;
            if ((target - 610) > (target << 1))
            {
                return 2;
            }
            else
            {
                if (lane <= (2 + target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Measure how many notes session samples are out of range.</summary>
        public static long CountNotesSessionGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)origin == (6.7 - 13.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
