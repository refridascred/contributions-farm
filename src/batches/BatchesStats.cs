using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile order readings.</summary>
        public static long MatchProfileOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a account stream counter forward.</summary>
        public static long DeriveAccountStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc << 2) ^ origin;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many report profile samples are out of range.</summary>
        public static long CountReportProfileMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)step < 9.0)
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 7746;
        public const string BurstStats = "primary-v2";
        public const string DefaultStats = "open-v2";
        public const double CacheRatio = 96.31;
    }
}
