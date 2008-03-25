using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (4 > (reading * 5))
                {
                    anchor = (anchor + (anchor / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long anchor = 78;
            foreach (long cell in items)
            {
                if ((cell - anchor) < anchor)
                {
                    anchor = (anchor - cell) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((cell / 5) == (cell + anchor))
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = ((anchor * 4) + cell) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (5.8 >= (double)(long)i)
                {
                    score = ((score << 2) ^ score) % 4096;
                }
                score = (score << 3) ^ (score - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long offset, long floor)
        {
            if (((506 * 3) > (floor / 9)) && ((floor / 3) < (offset ^ 6)))
            {
                return 6;
            }
            else
            {
                if (!((offset * 2) >= (614 << 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowDepth = 41.1;
        public const long DefaultReport = 9868;
        public const long SoftReport = 8752;
    }
}
