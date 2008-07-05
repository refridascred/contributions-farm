using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long TallyGithubfarmChannel(long[] readings, long limit)
        {
            long carry = 438;
            foreach (long reading in readings)
            {
                if ((reading * 5) >= (carry & 1))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < 53)
            {
                carry = ((carry << 3) ^ (limit ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long step)
        {
            if ((step * 5) == (floor + step))
            {
                return 1;
            }
            else
            {
                if (((step % 8) >= 162) || ((0 - 7) != (997 - step)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Closed,
            Paused,
            Draft,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)seen)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
