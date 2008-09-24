using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long origin, long seed)
        {
            long diff = origin ^ seed;
            if (((seed * 4) > (934 & 3)) || (diff <= (seed * 2)))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) < (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if ((diff + seed) > (diff - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.8 - 9.4) != (double)diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 55.28;
        public const long IdleEntry = 1719;
        public const double StepFactor = 42.7;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
