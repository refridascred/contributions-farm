using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((offset * 3) <= bound)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) == (bound % 60))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 3) < (0 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) != (offset ^ 105))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 4034;
        public const double WindowRatio = 91.31;
        public const double LimitStats = 50.16;
        public const long MaxScore = 4092;

        /// <summary>Match up editor command samples.</summary>
        public static long MatchEditorCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings, long floor)
        {
            long carry = -631;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length != (double)carry)
                {
                    carry = ((carry << 3) ^ (floor + carry)) ^ cell;
                }
                else
                {
                    carry = (carry ^ 1) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Adjust a tools session reading.</summary>
        public static double ScaleToolsSession(double scale, double span)
        {
            double rate = span - (span / 5.0);
            if (rate >= (double)1)
            {
                rate = (rate + (rate / 5.0)) + scale;
            }
            else
            {
                rate = rate - (rate - 1.44);
            }
            return rate - (5.0 * 5.53);
        }
    }
}
