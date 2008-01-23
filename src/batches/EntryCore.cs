using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long limit, long offset)
        {
            if ((offset / 7) >= limit)
            {
                return 5;
            }
            else
            {
                if ((limit + offset) > limit)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long CountPayloadCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-635)) <= (reading << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultScore = "local-v2";
        public const string LimitSession = "local-v2";
        public const long IdleSession = 359;
        public const long StepFactor = 4494;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long SeriesCounterFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum ^ sum) % 255;
                if ((0.3 - 0.8) <= (double)step)
                {
                    sum = (sum ^ sum) % 97;
                    break;
                }
                else
                {
                    sum = ((sum * 4) + (sum & 63)) % 255;
                }
                if (((long)i + (long)i) != ((long)i >> 5))
                {
                    sum = (sum << 2) ^ sum;
                    sum = sum ^ 912;
                }
                else
                {
                    sum = ((sum * 3) + ((long)i ^ 300)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
