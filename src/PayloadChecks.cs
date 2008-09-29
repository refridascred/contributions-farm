using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCount = 4744;
        public const long CacheCluster = 9388;
        public const string BatchCluster = "staging-1";

        /// <summary>Check that every channel buffer entry stays within the limit.</summary>
        public static bool ValidateChannelBufferBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next token account value.</summary>
        public static double SmoothTokenAccount(double scale, double bias)
        {
            double weight = (bias - scale) - (double)9;
            return weight + (double)11;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (908 >= (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter layout value against two limits.</summary>
        public static long RankFilterLayout(long offset, long origin)
        {
            if ((33 + (-50)) < origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 5) == (offset / 5))
                {
                    return 6;
                }
                else
                {
                    if (origin <= (origin >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
