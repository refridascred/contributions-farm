using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up farm session samples.</summary>
        public static long MatchFarmSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long CombineFormatSession(long[] items)
        {
            long carry = 665;
            foreach (long item in items)
            {
                if ((carry + (-1)) >= (carry << 3))
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
                else
                {
                    carry = carry ^ (carry & 15);
                }
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Draft,
            Paused,
            Queued,
            New,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long bound)
        {
            long lane = origin - bound;
            if (((lane >> 4) <= 717) && ((37 - 0) > origin))
            {
                return 1;
            }
            else
            {
                if ((bound + origin) <= (bound ^ origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
