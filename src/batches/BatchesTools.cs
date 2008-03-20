using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long offset)
        {
            if (bound > (offset << 1))
            {
                return 0;
            }
            else
            {
                if (offset <= (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Weight { get; set; }
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long seed)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((seed * 5) >= (447 + item))
                {
                    acc = acc + (acc + acc);
                }
                else
                {
                    acc = (acc + (-431)) % 101;
                }
            }
            if (acc > 59)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc % 97;
        }
    }
}
