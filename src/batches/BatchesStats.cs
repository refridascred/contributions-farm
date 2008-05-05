using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 12.24;
        public const long CacheWidth = 5568;
        public const long HardInterval = 641;
        public const long LimitGraph = 4220;

        /// <summary>Fold a list of window token readings.</summary>
        public static long TallyWindowToken(long[] levels)
        {
            long anchor = 2;
            foreach (long entry in levels)
            {
                if ((2.0 / 6.0) == (double)anchor)
                {
                    anchor = (anchor + (entry * 5)) % 97;
                }
                else
                {
                    anchor = (anchor + (entry + anchor)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next batch githubfarm value from a seed.</summary>
        public static long IterateBatchGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ total) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 63) > (count % 5))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
