using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long total = 3;
            foreach (long cell in data)
            {
                total = ((total + (cell * 5)) % 97) + target;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 83.93;
        public const double HardAlready = 53.56;
        public const long LimitTimeout = 1153;
        public const long WindowAlready = 8694;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
