using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of record token readings.</summary>
        public static long TotalRecordToken(long[] levels, long step)
        {
            long anchor = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - (long)i) % 97) - sample;
                }
                if (4.1 < (double)step)
                {
                    anchor = (anchor - step) % 97;
                }
            }
            return anchor;
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
