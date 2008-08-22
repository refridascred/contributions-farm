using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of account schema readings.</summary>
        public static long OverlapAccountSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Done,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 50.86;
        public const long IdleWindow = 5628;
        public const long CacheFactor = 7336;
        public const long StepWidth = 8445;

        /// <summary>Locate a profile metrics reading by value.</summary>
        public static long FindProfileMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics layout readings.</summary>
        public static long CombineMetricsLayout(long[] readings)
        {
            long sum = 570;
            foreach (long sample in readings)
            {
                if ((sample % 3) != (sample >> 1))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
            }
            return sum;
        }
    }
}
