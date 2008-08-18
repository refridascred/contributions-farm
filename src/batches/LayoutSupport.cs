using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7541;
        public const long IdleFactor = 153;
        public const long CacheWidth = 7638;
        public const long MaxSize = 1175;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((step - (long)data.Length) >= matches)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}
