using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit context checks readings against a rule.</summary>
        public static long CountContextChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of graph order readings.</summary>
        public static long DigestGraphOrder(long[] readings, long limit)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                score = (((score * 3) + 681) % 4096) ^ sample;
                if (limit <= (limit % 64))
                {
                    score = ((score << 2) ^ limit) % 101;
                }
                if (score < limit)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
