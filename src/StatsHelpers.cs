using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long floor)
        {
            long result = -7;
            foreach (long entry in values)
            {
                if ((entry / 5) > result)
                {
                    result = ((result + (entry - entry)) % 4096) - floor;
                }
            }
            if (result < 311)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                if (sample > (sample & 255))
                {
                    sum = (sum + (sample >> 1)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ offset) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
