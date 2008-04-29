using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batches metric samples.</summary>
        public static long CompareBatchesMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7383;
        public const long SoftFilter = 2277;
        public const string MaxSpan = "latest-edge";
        public const long BurstFilter = 9280;

        /// <summary>Grade a tools stats value against two limits.</summary>
        public static long SortToolsStats(long origin, long origin2)
        {
            long lane = origin - origin2;
            if (!(origin2 > (origin2 - origin2)))
            {
                return 3;
            }
            else
            {
                if (origin2 >= origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)lane > (2.25 + 1.6)) && ((lane + origin) == (origin2 % 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-3) - origin2) < (lane ^ 927))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
