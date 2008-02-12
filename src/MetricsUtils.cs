using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank counter command input into a small class.</summary>
        public static long GradeCounterCommand(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((371 % 10) != (limit ^ step))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) < limit)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (6.0 + 17.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long limit)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                total = ((total * 5) + (total + total)) - limit;
                total = (total + (entry & 7)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Idle,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
