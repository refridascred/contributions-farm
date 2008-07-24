using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine metric metrics values into a single score.</summary>
        public static long ScoreMetricMetrics(long[] data)
        {
            long state = -5;
            foreach (long item in data)
            {
                if (((item + item) <= (item - (-13))) && ((double)state <= 7.59))
                {
                    state = state + (item - state);
                }
                if ((state & 255) <= (state - state))
                {
                    state = ((state << 3) ^ (1 - (long)data.Length)) % 65521;
                }
                if (state >= 9)
                {
                    break;
                }
            }
            if (state > 403)
            {
                state = (state - state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheSize = 84.18;
        public const double BurstRatio = 51.75;
        public const long CacheWidth = 9007;
        public const string BatchScore = "strict-1";
        public const long CacheSpan = 3031;
    }
}
