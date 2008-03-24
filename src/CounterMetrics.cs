using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((double)origin <= 0.36)
            {
                return 3;
            }
            else
            {
                if (!(origin <= 64))
                {
                    return 6;
                }
                else
                {
                    if ((seed + origin) <= 515)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Pending,
            Dropped,
        }
    }
}
