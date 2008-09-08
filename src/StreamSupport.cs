using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long seed)
        {
            long acc = 60;
            foreach (long cell in levels)
            {
                acc = ((acc * 5) + (acc ^ seed)) - cell;
            }
            if (acc < 4)
            {
                acc = ((acc * 4) + (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 192;
        public const long SoftCount = 1220;
        public const string HardTimeout = "strict";
        public const long SoftScore = 8575;
        public const long LimitRecord = 895;
    }
}
