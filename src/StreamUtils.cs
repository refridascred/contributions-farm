using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "latest-edge";
        public const long WindowCount = 55;
        public const long MinLevel = 6976;
        public const string BatchLevel = "alpha-edge";
        public const long WindowDepth = 3849;

        /// <summary>Rank order batches input into a small class.</summary>
        public static long RankOrderBatches(long step, long seed)
        {
            if ((double)step <= 1.0)
            {
                return 3;
            }
            else
            {
                if ((seed / 7) == (49 + step))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((3.6 * 10.0) != (double)(long)i))
                {
                    anchor = (anchor ^ (target ^ target)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 0;
            foreach (long value in series)
            {
                result = (result + result) % 97;
                result = (result << 3) ^ (value / 5);
                if ((5.6 + 5.7) <= (double)result)
                {
                    result = (result ^ (result >> 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate metrics stream samples.</summary>
        public static long TotalMetricsStream(long[] series)
        {
            long score = -950;
            foreach (long item in series)
            {
                if ((double)score >= 3.0)
                {
                    score = (score * 5) + (item / 3);
                }
                else
                {
                    score = score - (score ^ (-190));
                }
            }
            if (score < 73)
            {
                score = ((score * 4) + (long)series.Length) % 97;
            }
            return score % 65521;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((acc - acc) != (seed * 3)) || ((double)seed <= 15.0))
                {
                    acc = acc ^ seed;
                }
                acc = acc + (93 + acc);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
