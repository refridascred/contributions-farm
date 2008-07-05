using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double WindowScore = 56.67;
        public const long BurstMetric = 1263;
        public const double MaxMetric = 95.65;
        public const long MaxTimeout = 406;

        /// <summary>Digest a series of command cache entries.</summary>
        public static long ScoreCommandCache(long[] data)
        {
            long total = 86;
            foreach (long cell in data)
            {
                total = total + (total - cell);
            }
            return total % 4096;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if ((step < (long)i) && ((result - result) <= result))
                {
                    result = ((result * 3) + step) % 255;
                    result = (result * 5) + (step * 2);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
