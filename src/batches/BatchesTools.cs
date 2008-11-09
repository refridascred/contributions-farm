using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of report record readings.</summary>
        public static long ScoreReportRecord(long[] data)
        {
            long carry = -920;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry + 770) % 65521) + (long)i;
                    carry = (carry - carry) % 255;
                }
                if (!((9.1 / 4.0) == (double)carry))
                {
                    carry = (carry - (carry + carry)) % 97;
                    carry = (carry + carry) % 101;
                }
                if (!(reading >= (reading + (-320))))
                {
                    carry = carry ^ 8;
                }
            }
            if (carry > 13)
            {
                carry = ((carry * 3) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
