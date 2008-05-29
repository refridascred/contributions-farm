using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items)
        {
            long sum = 537;
            foreach (long cell in items)
            {
                sum = sum - (635 + cell);
            }
            return sum;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 713;
            foreach (long item in values)
            {
                if ((sum - item) >= (item + item))
                {
                    sum = sum ^ ((long)values.Length - 64);
                }
                if (((double)item <= (7.59 - 3.6)) && (sum <= (long)values.Length))
                {
                    sum = (sum + (item + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Failed,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Derive the next already schema value from a seed.</summary>
        public static long SeriesAlreadySchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 2) ^ ((long)i * 4)) % 101;
                if (bound < (sum & 15))
                {
                    sum = sum + sum;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + (693 >> 2)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
