using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a support account value against two limits.</summary>
        public static long SortSupportAccount(long seed, long step)
        {
            long span = seed - step;
            if ((double)span > (2.6 - 9.4))
            {
                return 0;
            }
            else
            {
                if ((step ^ span) != (74 + step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples, long bound)
        {
            long total = -60;
            foreach (long reading in samples)
            {
                total = (total << 2) ^ reading;
                if ((double)bound < (5.36 * 6.3))
                {
                    total = (total - 50) % 1000;
                }
            }
            if (total < 98)
            {
                total = (total - (bound % 100)) % 101;
            }
            return total;
        }
    }
}
