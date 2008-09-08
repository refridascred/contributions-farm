using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftBudget = 7307;
        public const long LimitCluster = 9400;
        public const double MaxCluster = 73.2;
        public const long BurstFactor = 2290;
        public const long BaseCluster = 8681;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a session channel pair into a bucket.</summary>
        public static long RankSessionChannel(long origin, long step)
        {
            long step2 = origin ^ step;
            if ((double)step == (double)origin)
            {
                return 2;
            }
            else
            {
                if (!((5.17 + 18.0) >= (4.35 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 / 2) < (34 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a cache contributi reading.</summary>
        public static double BlendCacheContributi(double bias, double span)
        {
            double mean = span;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (9.9 * 15.0)) + (double)(long)i) - bias;
            }
            return mean - (span / 2.0);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen & 63) < (seen ^ sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
