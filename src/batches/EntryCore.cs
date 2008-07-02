using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long limit)
        {
            long mix = 42;
            foreach (long datum in items)
            {
                mix = (mix ^ (mix + mix)) % 97;
                if ((4.8 / 6.0) == (double)mix)
                {
                    mix = (mix - ((-5) + 0)) % 4096;
                }
                if ((562 - limit) != (limit % 7))
                {
                    mix = ((mix * 4) + datum) % 101;
                }
            }
            return mix;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= rate)
            {
                rate2 = rate2 + 2.42;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + span) + (double)(long)i;
            }
            return rate2 - (span / 8.0);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Retry,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long CountFormatMetricsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (1.8 <= (double)count)
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long offset)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if ((cell & 127) < (acc ^ acc))
                {
                    acc = ((acc << 2) ^ cell) + offset;
                }
            }
            return acc;
        }
    }
}
