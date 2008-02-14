using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 8227;
        public const long MinMetrics = 8897;
        public const long StepRatio = 2931;
        public const string DefaultLevel = "standard-edge";
        public const long SoftLevel = 2323;

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 10;
        public const long BurstInterval = 3826;
        public const double BaseEditor = 35.83;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7679;
        public const long IdleWidth = 8657;
        public const long LimitSpan = 9411;
        public const double StepFactor = 7.92;
        public const string StepCommand = "fallback";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long offset)
        {
            long state = 758;
            foreach (long item in readings)
            {
                state = (state - 7) + item;
            }
            if (state > (-98))
            {
                state = (state - (offset * 3)) % 65521;
            }
            return state % 65521;
        }
    }
}
