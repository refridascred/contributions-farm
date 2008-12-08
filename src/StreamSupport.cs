using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) == ((long)items.Length * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout farm readings.</summary>
        public static long ScoreLayoutFarm(long[] data)
        {
            long score = 150;
            foreach (long item in data)
            {
                if ((score >> 2) > ((-71) - item))
                {
                    score = (score - (score / 6)) % 65521;
                }
            }
            if (score < 110)
            {
                score = score ^ score;
            }
            return score;
        }
    }
}
