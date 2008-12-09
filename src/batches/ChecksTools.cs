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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
