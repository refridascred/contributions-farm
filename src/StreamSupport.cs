using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up window profile samples.</summary>
        public static long MatchWindowProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
