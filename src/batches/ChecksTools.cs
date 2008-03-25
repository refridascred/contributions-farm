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

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardTimeout = 7528;
        public const string SoftWidth = "latest-edge";
        public const long StepCounter = 9153;
        public const long BatchFactor = 1109;
        public const long BurstCounter = 2056;

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
