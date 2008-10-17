using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7367;
        public const double LimitInterval = 39.67;
        public const string SoftContext = "alpha";
        public const long LimitContext = 8979;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchInterval = 13;
        public const double StepSpan = 36.62;
        public const long SoftCount = 1553;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
