using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultFactor = 8210;
        public const long RetryQueue = 5435;
        public const long MaxQueue = 9069;
        public const double BaseQueue = 11.16;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "primary-v2";
        public const string BatchFarm = "open-1";
        public const string SoftScore = "staging-1";
        public const long IdleFarm = 101;
        public const long WindowFarm = 456;
    }
}
