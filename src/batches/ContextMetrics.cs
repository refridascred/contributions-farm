using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 8828;
        public const long RetryStats = 2883;
        public const long MaxLevel = 7230;

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1059;
        public const long LimitSchema = 3533;
        public const double DefaultSchema = 37.89;
        public const long BatchSchema = 1227;
        public const long StepSchema = 4830;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long anchor = 18;
            foreach (long reading in data)
            {
                if ((1.0 > (double)(long)data.Length) || (((long)data.Length ^ step) <= step))
                {
                    anchor = (anchor - (reading >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
