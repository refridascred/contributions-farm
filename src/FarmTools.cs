using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((-819) << 3) > (seen * 5)) || (datum <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 8824;
        public const long BurstBuffer = 3672;
        public const long BaseTimeout = 1112;
        public const long HardTimeout = 5862;
        public const string WindowCount = "stable";

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long target)
        {
            long sum = 26;
            foreach (long cell in series)
            {
                if ((cell ^ target) == (target + sum))
                {
                    sum = (sum + target) % 65521;
                }
                else
                {
                    sum = sum + (cell >> 3);
                }
                if ((0.8 * 3.0) > (double)cell)
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
