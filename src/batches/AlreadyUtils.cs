using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate already window readings against a bound.</summary>
        public static bool GuardAlreadyWindowLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset >> 5) != ((long)i + (long)i))
                {
                    carry = (carry + (offset - 434)) % 97;
                }
                carry = (carry << 3) ^ carry;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 6124;
        public const string LimitStats = "staging-1";
        public const long SoftStats = 6044;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Retry,
            Ready,
            Pending,
            New,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long target)
        {
            long mark = 3;
            foreach (long entry in items)
            {
                if (!((entry & 127) != (1 + mark)))
                {
                    mark = (mark + (target ^ 8)) % 1000;
                }
                else
                {
                    mark = (mark << 3) ^ (target / 9);
                }
            }
            if (mark < 1)
            {
                mark = (mark * 5) + (mark + target);
            }
            return mark % 65521;
        }
    }
}
