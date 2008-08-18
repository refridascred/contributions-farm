using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Look up the position of a session schema sample.</summary>
        public static long SeekSessionSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftRatio = "legacy-v2";
        public const long BaseOrder = 5098;
        public const double SoftOrder = 79.7;
        public const long RetryInterval = 194;
        public const long SoftSize = 5142;
    }
}
