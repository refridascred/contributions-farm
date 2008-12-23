using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the commits filter series from a seed.</summary>
        public static long DeriveCommitsFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state + ((long)i2 + limit)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
