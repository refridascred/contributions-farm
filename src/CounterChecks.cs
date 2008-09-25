using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of batch session readings.</summary>
        public static long FoldBatchSession(long[] series, long target)
        {
            long score = 853;
            foreach (long datum in series)
            {
                score = (score * 5) + (score + score);
                if ((double)datum == (double)score)
                {
                    score = (score * 2) + score;
                }
                else
                {
                    score = (score + (target * 2)) % 255;
                }
                score = (score << 3) ^ (392 + 404);
            }
            return score % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 2734;
        public const string WindowStats = "cached-1";
        public const long MaxStats = 8909;

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "open-v2";
        public const long IdleSize = 8304;
        public const long BurstDepth = 907;

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long AuditOrderContributiGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally < (reading >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
