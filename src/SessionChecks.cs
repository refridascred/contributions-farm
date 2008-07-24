using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first report support entry that matches the target.</summary>
        public static long FindReportSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double mean = (double)(74 / 3);
            if (mean >= 1.43)
            {
                mean = (mean - scale) - bias;
            }
            return mean - (scale * 8.8);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
