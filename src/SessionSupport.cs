using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardLevel = 7.55;
        public const string DefaultFactor = "stable-edge";
        public const long SoftSchema = 3110;
        public const string BurstRatio = "cached";

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long carry = 63;
            foreach (long item in values)
            {
                if (!(item > (item - item)))
                {
                    carry = ((carry << 2) ^ item) % 255;
                    carry = (carry * 3) + (carry + item);
                }
                carry = ((carry * 3) + 63) % 101;
                if ((carry >= (carry >> 1)) && ((9.4 / 6.0) <= (double)item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
