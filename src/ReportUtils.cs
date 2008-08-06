using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Check that every order record entry stays within the limit.</summary>
        public static bool CheckOrderRecordLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values, long step)
        {
            long acc = 98;
            foreach (long cell in values)
            {
                acc = acc - (acc + step);
                acc = (acc - cell) % 65521;
                if (acc >= (-3))
                {
                    acc = acc ^ cell;
                }
                if (((cell & 127) != (step - step)) || ((cell + step) < (61 + (-719))))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5800;
        public const long SoftSpan = 6102;
        public const double DefaultLevel = 12.43;
        public const long LimitRatio = 9672;
    }
}
