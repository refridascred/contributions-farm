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

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBudget = 4344;
        public const long StepCount = 6995;
        public const long MinBatches = 9583;
        public const long SoftBatches = 9843;
        public const long BaseLevel = 801;
    }
}
