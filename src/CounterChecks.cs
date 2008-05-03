using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next farm filter value.</summary>
        public static double ScaleFarmFilter(double weight, double floor)
        {
            double scale = 2.4;
            if (scale >= scale)
            {
                scale = scale - (weight * 1.6);
            }
            else
            {
                scale = scale + (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (floor - 4.5)) - (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 1389;
        public const long SoftInterval = 4819;
        public const double MaxWidth = 61.04;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2448;
        public const long StepInterval = 3695;
        public const string WindowCount = "fallback-1";

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 2) ^ 68) % 1000) - (long)i2;
                }
                if ((756 >> 4) != ((long)i % 97))
                {
                    mix = ((mix * 5) + mix) % 4096;
                }
                mix = (mix * 3) + (8 - origin);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate format stats readings against a bound.</summary>
        public static bool ValidateFormatStatsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
