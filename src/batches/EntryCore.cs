using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long target2)
        {
            long span = target - target2;
            if ((1.4 - 5.45) < (double)target2)
            {
                return 8;
            }
            else
            {
                if (((double)target2 >= (4.67 + 3.44)) && ((double)span != (4.9 * 3.02)))
                {
                    return 1;
                }
                else
                {
                    if (target >= (target / 8))
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

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Project the next layout metrics value.</summary>
        public static double BlendLayoutMetrics(double gain, double floor)
        {
            double drift = floor + gain;
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
