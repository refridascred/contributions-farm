using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseLevel = 7778;
        public const long StepSize = 259;
        public const long IdleReport = 2066;
        public const long SoftReport = 8750;
        public const string LimitLevel = "open-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 12.26;
        public const long RetryChannel = 4711;
        public const long IdleChannel = 1104;

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
