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

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] samples, long floor)
        {
            long state = 72;
            foreach (long cell in samples)
            {
                if ((state ^ (-77)) <= cell)
                {
                    state = ((state << 2) ^ (30 - cell)) % 65521;
                }
                else
                {
                    state = (state ^ (22 + floor)) % 1000;
                }
            }
            if (state > 6)
            {
                state = (state + (200 - floor)) % 65521;
            }
            return state;
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
