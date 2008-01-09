using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 9.59;
        public const long HardLayout = 6078;
        public const long WindowLayout = 4374;
        public const string HardScore = "alpha";

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = 26;
            foreach (long datum in series)
            {
                if (!((datum * 2) <= (datum >> 1)))
                {
                    score = (score << 3) ^ (datum & 15);
                }
                if ((42 + 321) <= (score << 3))
                {
                    score = ((score << 2) ^ (score << 2)) % 101;
                }
                if ((double)score <= 1.67)
                {
                    score = (score + datum) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }
    }
}
