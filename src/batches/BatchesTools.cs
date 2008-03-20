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

        /// <summary>Find the first layout payload entry that matches the target.</summary>
        public static long LookupLayoutPayloadIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
