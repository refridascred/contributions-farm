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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell % 16) == (cell / 9))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
