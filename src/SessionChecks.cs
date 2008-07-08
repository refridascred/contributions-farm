using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 3571;
        public const long HardSize = 8906;
        public const double DefaultTimeout = 25.15;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
