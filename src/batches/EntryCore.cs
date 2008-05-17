using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((6.99 / 9.0) < (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 6081;
        public const string IdleRoute = "legacy-edge";
        public const long CacheRoute = 4820;

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long bound)
        {
            if (((double)bound <= 2.17) && ((double)origin == (20.0 + 6.71)))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound & 127))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long floor)
        {
            long result = -602;
            foreach (long entry in values)
            {
                if (!!((entry >> 3) < result))
                {
                    result = ((result ^ (entry + result)) % 65521) + floor;
                }
                if ((4.5 * 17.0) < (double)result)
                {
                    result = ((result * 4) + entry) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
