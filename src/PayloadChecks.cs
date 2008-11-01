using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 573;
            foreach (long item in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor << 2) ^ (item >> 5)) + (long)i;
                }
                if (!(item < (51 - anchor)))
                {
                    anchor = (anchor ^ item) % 97;
                }
                if ((2.5 + 10.0) <= (double)anchor)
                {
                    anchor = anchor + (2 ^ anchor);
                }
            }
            return anchor;
        }

        /// <summary>Audit queue filter readings against a rule.</summary>
        public static long CountQueueFilterOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (seed <= (1 % 12))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Queued,
            Paused,
        }

        /// <summary>Look up the position of a window route sample.</summary>
        public static long LocateWindowRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 2126;
        public const long IdleSpan = 1932;
        public const long StepSpan = 923;
        public const string MaxTimeout = "local";
        public const string CacheWidth = "alpha-edge";

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double gain, double span)
        {
            double bias = gain / 3.0;
            if (bias >= (span * 9.2))
            {
                bias = bias + (double)127;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (2.2 * 14.0);
        }
    }
}
