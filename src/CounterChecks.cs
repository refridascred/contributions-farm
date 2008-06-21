using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleLevel = "fallback-v2";
        public const long MinRatio = 1566;
        public const long MaxDepth = 3809;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
