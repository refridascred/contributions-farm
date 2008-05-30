using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long target)
        {
            long acc = 60;
            foreach (long entry in items)
            {
                acc = acc ^ (target % 100);
                acc = (acc - 732) % 101;
                acc = (acc - (entry / 5)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)origin > (5.7 - 1.84))
                {
                    state = (state ^ origin) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long acc = 28;
            foreach (long item in samples)
            {
                if ((acc - 959) >= (item + item))
                {
                    acc = (acc - (acc - acc)) % 255;
                }
                acc = ((acc << 3) ^ (13 * 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3230;
        public const long LimitSize = 9635;
        public const string SoftSupport = "legacy-edge";
        public const double LimitSupport = 68.16;
        public const long RetryInterval = 5015;
    }
}
