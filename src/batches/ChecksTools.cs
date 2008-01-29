using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((0.9 * 5.0) <= (double)(long)readings.Length))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 2) + (425 - anchor)) % 1000) ^ cell;
            }
            if (anchor < 812)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
