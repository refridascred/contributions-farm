using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Failed,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Roll a report metric counter forward.</summary>
        public static long StepReportMetric(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values, long floor)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if (176 <= (value ^ mark))
                {
                    mark = ((mark << 3) ^ (value * 4)) - floor;
                }
            }
            return mark;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool CheckTokenReportBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
