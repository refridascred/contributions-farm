using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up support route samples.</summary>
        public static long CompareSupportRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Scale a layout buffer figure with a bias.</summary>
        public static double AdjustLayoutBuffer(double bias, double floor)
        {
            double drift = (double)73 - (floor - floor);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift + drift)) - (double)(long)i) - bias;
            }
            return drift - (floor * 4.0);
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Retry,
            Failed,
            Closed,
        }
    }
}
