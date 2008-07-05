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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
