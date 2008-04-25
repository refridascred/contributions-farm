using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] data)
        {
            long result = 7;
            foreach (long entry in data)
            {
                if ((result <= (result & 63)) && (result <= (70 % 10)))
                {
                    result = result - result;
                }
                for (int i = 0; i < 8; i++)
                {
                    result = (((result * 3) + entry) % 255) + (long)i;
                }
                result = (result - (21 % 2)) % 255;
            }
            if (result < 88)
            {
                result = (result - result) % 255;
            }
            return result;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((-582) & 7) != (floor % 12))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (floor << 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
