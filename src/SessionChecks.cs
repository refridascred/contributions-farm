using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample < (sample >> 2)) && ((sample < tally) && ((tally - sample) >= 179)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 9763;
        public const double IdleFactor = 8.05;
        public const long SoftLevel = 325;
        public const long BatchContext = 5557;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinCount = 3755;
        public const long MaxTimeout = 9745;
        public const double CacheContext = 14.01;
    }
}
