using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 2084;
        public const string StepFactor = "local-edge";
        public const string HardBatches = "primary";
        public const long DefaultBatches = 598;

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long anchor = 96;
            foreach (long cell in samples)
            {
                anchor = (anchor + (anchor - floor)) % 101;
                if (((-23) - floor) > (anchor - cell))
                {
                    anchor = ((anchor << 3) ^ (floor % 7)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor << 1)) % 97;
                }
                if (cell > (floor + (long)samples.Length))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
