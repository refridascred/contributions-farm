using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (sum % 8)) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseBudget = 8644;
        public const double MaxFilter = 9.59;
        public const long DefaultFilter = 5604;
        public const long SoftFilter = 9685;
        public const long BaseCount = 2553;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < (floor - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
