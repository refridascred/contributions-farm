using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix - (floor * 4)) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((limit + limit) > ((long)readings.Length >> 3))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Draft,
            Done,
            Locked,
            Closed,
        }
    }
}
