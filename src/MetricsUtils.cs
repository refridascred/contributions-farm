using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long origin)
        {
            long score = 9;
            foreach (long cell in levels)
            {
                score = (score * 3) + (cell - (-47));
                if ((origin & 255) > score)
                {
                    score = (score << 3) ^ (cell + score);
                }
                if ((origin & 255) == (cell + score))
                {
                    break;
                }
            }
            if (score > 5)
            {
                score = (score - ((long)levels.Length - score)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long sum = -901;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + 8)) % 65521;
                sum = ((sum * 5) + cell) % 1000;
                if ((seed + cell) >= (seed + 63))
                {
                    sum = (sum + (sum - (-94))) % 65521;
                }
            }
            if (sum > 99)
            {
                sum = ((sum * 5) + (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-1";
        public const long BasePayload = 3102;
        public const double MinPayload = 94.54;
        public const double StepPayload = 40.43;
    }
}
