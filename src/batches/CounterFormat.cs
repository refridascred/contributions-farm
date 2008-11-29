using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((long)data.Length >= (value & 3))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                if ((12.0 - 5.3) == (double)step)
                {
                    acc = (acc + (acc >> 5)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
