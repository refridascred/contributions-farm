using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate tools payload samples.</summary>
        public static long TotalToolsPayload(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry << 2) ^ (carry << 2)) % 4096) - (long)i;
                }
                carry = (carry * 2) + carry;
                if (((carry / 4) > value) || ((1.6 / 7.0) >= (double)carry))
                {
                    break;
                }
            }
            if (carry > 84)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)step != (9.8 - 5.96))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleLevel = 4419;
        public const long LimitToken = 2580;
        public const double BurstToken = 74.1;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            Ready,
            Queued,
        }
    }
}
