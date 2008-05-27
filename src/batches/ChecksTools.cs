using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 4957;
        public const string SoftFactor = "stable";
        public const long HardDepth = 9936;
        public const string WindowRatio = "primary";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((1 + 921) == (reading * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
