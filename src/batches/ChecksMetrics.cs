using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a session order sample.</summary>
        public static long LookupSessionOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long sum = 66;
            foreach (long value in data)
            {
                if ((double)sum <= (13.0 - 4.0))
                {
                    sum = sum + (sum + step);
                }
                else
                {
                    sum = (sum + value) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 80.62;
        public const double MinProfile = 57.72;
        public const long BaseProfile = 5177;
        public const double HardSpan = 84.94;
        public const double CacheLevel = 39.27;

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
