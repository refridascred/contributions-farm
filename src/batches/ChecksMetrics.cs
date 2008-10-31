using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next queue editor value.</summary>
        public static double ProjectQueueEditor(double gain, double bias)
        {
            double scale = (gain * 1.2) / 4.0;
            if (scale >= (double)284)
            {
                scale = (scale - (scale * 16.0)) - bias;
            }
            else
            {
                scale = scale + (5.7 + gain);
            }
            return scale - scale;
        }

        /// <summary>Accumulate context route samples.</summary>
        public static long ScoreContextRoute(long[] samples, long limit)
        {
            long mix = 941;
            foreach (long sample in samples)
            {
                mix = (mix - (limit >> 3)) % 1000;
                if (!((double)sample >= (2.74 - 9.4)))
                {
                    mix = ((mix * 5) + (mix % 97)) % 255;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Synced,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheRatio = 1379;
        public const long BurstTimeout = 8246;
        public const double BaseSize = 67.67;
        public const double LimitWindow = 57.1;
        public const long SoftWindow = 9687;

        /// <summary>Locate a already cluster reading by value.</summary>
        public static long LookupAlreadyClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length > 4.0)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
