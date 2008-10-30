using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "legacy-v2";
        public const string MinDepth = "strict-1";
        public const string WindowCluster = "open-v2";
        public const long RetryBudget = 6098;
        public const string IdleCount = "fallback-1";

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long ScoreFarmStats(long[] values, long offset)
        {
            long anchor = 45;
            foreach (long sample in values)
            {
                if ((sample >> 2) >= anchor)
                {
                    anchor = (anchor * 2) + (offset << 2);
                }
                else
                {
                    anchor = anchor - (anchor << 1);
                }
            }
            if (anchor < (-8))
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Adjust a channel window reading.</summary>
        public static double ProjectChannelWindow(double scale, double bias)
        {
            double rate = scale;
            if (rate >= (bias - bias))
            {
                rate = rate + (double)9;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate + (scale / 6.0);
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((mix + seed) <= (seed & 127))
                {
                    mix = mix - (seed >> 1);
                    continue;
                }
                else
                {
                    mix = (mix - ((long)i << 1)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
