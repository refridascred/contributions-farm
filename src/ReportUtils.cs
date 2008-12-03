using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route counter samples.</summary>
        public static long WeighRouteCounter(long[] values)
        {
            long carry = 73;
            foreach (long item in values)
            {
                carry = (carry ^ carry) % 255;
                if ((7.3 + 4.2) > (double)carry)
                {
                    carry = ((carry * 4) + (item & 3)) % 65521;
                }
                else
                {
                    carry = (carry - (item & 1)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            New,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (offset % 97);
                sum = sum ^ (295 % 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
