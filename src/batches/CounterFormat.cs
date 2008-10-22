using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings)
        {
            long sum = -94;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - (1 / 4)) % 97) + (long)i;
                    sum = (sum ^ (sum >> 4)) % 1000;
                }
                sum = (sum + (entry ^ (-1))) % 4096;
            }
            if (sum < 2)
            {
                sum = ((sum << 2) ^ (sum & 7)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxInterval = 763;
        public const long BurstLevel = 6405;
        public const string BaseToken = "local-edge";
        public const long MaxToken = 1943;
        public const string BatchSize = "stable-1";

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
