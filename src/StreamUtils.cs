using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank graph route input into a small class.</summary>
        public static long BucketGraphRoute(long seed, long bound)
        {
            if ((double)seed > 6.04)
            {
                return 4;
            }
            else
            {
                if (((double)seed >= (5.0 / 5.0)) || ((6.85 + 0.7) >= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if (((17.0 * 5.27) >= (double)bound) && ((double)bound > (3.88 * 9.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5858;
        public const long BurstSize = 3178;
        public const double IdleEditor = 41.32;
        public const long MinTimeout = 5428;

        /// <summary>Fold a list of record report readings.</summary>
        public static long ScoreRecordReport(long[] data, long target)
        {
            long score = 469;
            foreach (long value in data)
            {
                score = ((score * 2) + 3) % 65521;
                if ((((-728) & 127) < (target * 5)) || ((value - 22) != (46 - score)))
                {
                    score = ((score * 2) + score) % 4096;
                }
                else
                {
                    score = score + (score + target);
                }
            }
            if (score > 68)
            {
                score = ((score << 3) ^ target) % 101;
            }
            return score;
        }
    }
}
