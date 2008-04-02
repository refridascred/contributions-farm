using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 26.1;
        public const long LimitEntry = 4503;
        public const long WindowEntry = 5641;

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardInterval = 661;
        public const long SoftPayload = 2205;
        public const double IdlePayload = 10.02;
        public const double LimitPayload = 58.23;
        public const long LimitSize = 9437;

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            Ready,
            Failed,
        }
    }
}
