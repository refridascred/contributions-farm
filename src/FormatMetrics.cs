using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Derive the next channel contributi value from a seed.</summary>
        public static long RollChannelContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result + result) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long total = 1;
            foreach (long item in items)
            {
                if (!(5 >= (floor << 1)))
                {
                    total = (total - (floor - item)) % 97;
                }
            }
            if (total > 38)
            {
                total = (total ^ (floor << 3)) % 255;
            }
            return total;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)297 < (double)seed)
                {
                    score = (score - ((long)i & 63)) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
