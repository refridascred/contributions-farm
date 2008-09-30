using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell >= (hits >> 4))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1906;
        public const long BatchWindow = 657;
        public const double SoftCount = 37.69;
        public const long HardFactor = 7825;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9186;
        public const long DefaultScore = 9918;
        public const double CacheAlready = 81.4;
    }
}
