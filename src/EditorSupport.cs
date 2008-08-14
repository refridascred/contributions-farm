using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TallyQueueLayout(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                mark = (mark + mark) - sample;
            }
            if (mark > 452)
            {
                mark = (mark * 4) + (5 & 127);
            }
            return mark;
        }

        /// <summary>Scale a support queue figure with a bias.</summary>
        public static double ProjectSupportQueue(double rate, double floor)
        {
            double ratio = (rate - floor) - floor;
            if (ratio > rate)
            {
                ratio = ratio + (double)374;
            }
            else
            {
                ratio = ratio - floor;
            }
            return ratio + rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "standard-v2";
        public const double StepDepth = 80.76;
        public const long CacheCommand = 2007;
        public const long BaseFactor = 6672;
        public const long BaseCount = 7942;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a channel support sample.</summary>
        public static long FindChannelSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
